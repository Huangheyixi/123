using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNPOI
{
	public partial class About : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var list = new List<object>();
			list.Add(new { Name = "TianHao" });
			list.Add(new { Name = "TianHao2" });
			Repeater1.DataSource = list;
			Repeater1.DataBind();
			
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			////1、使用response.TransmitFile传输400MB以上的文件，不使用缓存
			//Response.ContentType = "application/x-zip-compressed";
			//Response.AddHeader("Content-Disposition", "attachment;filename=text.txt");
			//string fileName = Server.MapPath("text.txt");
			//Response.TransmitFile(fileName);
			//Response.Write("<script language=\"javascript\" type=\"text/javascript\">");
			//Response.Write("alert(\"下载成功\");");
			//Response.Write("window.location.href=\"C_SC.aspx\";");
			//Response.Write("</script>");

			//2、使用WriteFile方法下载文件
			//string filename = Server.MapPath("text.txt");
			//Response.ContentEncoding = Encoding.GetEncoding("gb2312");
			//Response.WriteFile(filename);

			//new DataTable
			DataTable table = new DataTable();
			table.Columns.Add(new DataColumn("ID"));
			table.Columns.Add(new DataColumn("Name"));
			table.Columns.Add(new DataColumn("time", typeof(DateTime)));
			table.Rows.Add(1, "name1", DateTime.Now);
			table.Rows.Add(2, "name2", DateTime.Now);

			//create excel
			XSSFWorkbook workbook = new XSSFWorkbook();
			workbook.CreateSheet("report");
			ISheet reportSheet = workbook.GetSheetAt(0);

			//set columns value
			int rowNum = 0;
			IRow columnRow = reportSheet.CreateRow(rowNum++);
			for (int i = 0; i < table.Columns.Count; i++)
			{
				ICell cell = columnRow.CreateCell(i);
				cell.SetCellValue(table.Columns[i].ColumnName);
			}

			//set cells value
			foreach (DataRow dataRow in table.Rows)
			{
				IRow row = reportSheet.CreateRow(rowNum++);
				for (int i = 0; i < table.Columns.Count; i++)
				{
					ICell cell = row.CreateCell(i);
					if (dataRow[i] is DateTime)
					{
						cell.SetCellValue((DateTime)dataRow[i]);
						ICellStyle style = workbook.CreateCellStyle();
						IDataFormat format = workbook.CreateDataFormat();
						style.DataFormat = format.GetFormat("yyyy/MM/dd HH:mm:ss");
						
						cell.CellStyle = style;
						cell.SetCellType(CellType.Numeric);
					}
					cell.SetCellValue(dataRow[i].ToString());
				}
			}

			string filename = "test.xlsx";
			workbook.Write(Response.OutputStream);
			workbook.Close();
			Response.ContentType = "application/x-zip-compressed";
			Response.AddHeader("Content-Disposition", $"attachment;filename={filename}");
			Response.End();

			//XSSFWorkbook workbook = new XSSFWorkbook();
			//workbook.CreateSheet("sheet1");
			//workbook.CreateSheet("sheet2");
			//workbook.CreateSheet("sheet3");
			//Stream outStream = Response.OutputStream;
			//workbook.Write(outStream);
			//outStream.Close();
			//workbook.Close();
		}
	}
}