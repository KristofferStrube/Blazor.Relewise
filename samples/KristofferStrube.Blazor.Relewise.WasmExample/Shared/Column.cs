﻿using Relewise.Client.DataTypes;
using Relewise.Client.Requests.Filters;

namespace KristofferStrube.Blazor.Relewise.WasmExample.Shared;

public class Column(Type filterColumnEditor, Type columnPresenter, Func<Product, object?> columnSelector)
{
    public Type FilterColumnEditor => filterColumnEditor;
    public Type ColumnPresenter => columnPresenter;
    public Func<Product, object?> ColumnSelector => columnSelector;
    public Filter? Filter { get; set; }
}

public class Column<TFilter>(Type filterColumnEditor, Type columnPresenter, Func<Product, object?> columnSelector) : Column(filterColumnEditor, columnPresenter, columnSelector);
