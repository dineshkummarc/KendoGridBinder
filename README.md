## Demo
http://kendogridbinder.apphb.com

## Action
```csharp
[HttpPost]
public JsonResult Grid(KendoGridRequest request)
{
    var employees = new List<Employee>
    {
        new Employee { EmployeeId = 1, FirstName = "Bill", LastName = "Jones", Email = "bill@email.com" },
        new Employee { EmployeeId = 2, FirstName = "Rob", LastName = "Johnson", Email = "rob@email.com" },
        new Employee { EmployeeId = 3, FirstName = "Jane", LastName = "Smith", Email = "jane@email.com" },
    };

    var grid = new KendoGrid<Employee>(request, employees);
    return Json(grid);
}
```

## HTML
```html
<div id="grid"></div>
```


## Script
```javascript
<script type="text/javascript">
    var url = '@Url.Action("Grid")';

    var dataSource = new kendo.data.DataSource({
        serverPaging: true,
        serverSorting: true,
        serverFiltering: true,
        pageSize: 20,
        transport: {
            read: {
                type: 'post',
                dataType: 'json',
                url: url
            }
        },
        schema: {
            data: 'data',
            total: 'total',
            model: {
                id: 'EmployeeId',
                fields: {
                    FirstName: { type: 'string' },
                    LastName: { type: 'string' },
                    Email: { type: 'string' }
                }
            }
        }
    });

    $('#grid').kendoGrid({
        dataSource: dataSource,
        height: 400,
        filterable: true,
        sortable: true,
        pageable: true
    });

</script>
```