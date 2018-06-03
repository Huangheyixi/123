
layui.use("table", function () {
    var table = layui.table;

    table.render({
        elem: '#testTable1',
        url: '/TableHandler.ashx?action=table1',
        cellMinWidth: 80,
        cols: [[
            { field: 'Id', title: 'ID', sort: true, width: 80 }
            , { field: "Name", title: "名字", sort: true }
            , { field: "Age", title: '年龄', sort: true }
            , { field: "Description", title: "备注" }
        ]],
        text: {
            none: "暂无数据"
        },
        done: function () {
            //alert('加载完成');
        },
        height: 'full-200',

    })
})