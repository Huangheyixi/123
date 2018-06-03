using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			WeakReference<Action<int>> weak = new WeakReference<Action<int>>(new Action<int>(a=>Console.WriteLine(a)));
			weak = null;
			GC.Collect();
			Console.ReadKey();
		}
	}
	public class WeakReference<TDelegate> : IEquatable<Delegate>
	{
		private GCHandle _handle;

		public WeakReference(Delegate obj)
		{
			if (obj == null) return;
			_handle = GCHandle.Alloc(obj, GCHandleType.Weak);
		}

		/// <summary>
		/// 引用的目标是否还存在（没有被GC回收）
		/// </summary>
		public bool IsAlive
		{
			get
			{
				return _handle != default(GCHandle) && _handle.Target != null;
			}
		}

		/// <summary>
		/// 引用的目标
		/// </summary>
		public TDelegate Target
		{
			get
			{
				if (_handle == default(GCHandle))
					return default(TDelegate);
				return (TDelegate)_handle.Target;
			}
		}

		/// <summary>
		/// 实现接口，方便与委托的比较
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(Delegate other)
		{
			return _handle != default(GCHandle) && other != null && 
				((Delegate)_handle.Target).Method.Equals(other.Method);
		}

		~WeakReference()
		{
			Console.WriteLine("GC已经释放了当前对象");
			_handle.Free();
		}
	}

	public class WeakEventManager
	{
		private readonly List<WeakReference<Delegate>> _delegateList;

		public WeakEventManager()
		{
			_delegateList = new List<WeakReference<Delegate>>();
		}

		public void AddHandle(Delegate handler)
		{
			if (handler != null)
				_delegateList.Add(new WeakReference<Delegate>(handler));
		}

		public void RemoveHandle(Delegate handler)
		{
			if (handler == null) return;
			var sameHandler = _delegateList.FirstOrDefault(e => e.Equals(handler));
			if(sameHandler!=null)
			{
				_delegateList.Remove(sameHandler);
			}
		}

		public void Raise(object sender,EventArgs e)
		{
			foreach(var d in _delegateList)
			{
				if(d.IsAlive)
				{
					d.Target.DynamicInvoke(sender, e);
				}
				else
				{
					_delegateList.Remove(d);
				}
			}
		}
	}
}
