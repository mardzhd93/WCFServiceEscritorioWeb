IF OBJECT_ID ('dbo.USP_VentasEInventario') IS NOT NULL
	DROP PROCEDURE dbo.USP_VentasEInventario
GO

create procedure  dbo.USP_VentasEInventario
	@Filtro varchar(30)
	as
	begin 
	set nocount on
	if @Filtro = 'Ventas Por Articulo'
	select pr.Titulo, pr.Descripcion, vt.CantidadVendida, vt.Fecha
	from Productos pr 
		inner join Ventas vt on (pr.IDProductos = vt.IDProductos)
		order by pr.Titulo
	if @Filtro = 'Ventas Globales'
		select sum(vt.CantidadVendida)CantidadVendida, sum(pr.PrecioUnitario)TotalVentas
	from Productos pr 
		inner join Ventas vt on (pr.IDProductos = vt.IDProductos)
	if @Filtro = 'Articulo Mas Vendidos'
	select top 5 pr.Titulo, pr.Descripcion, vt.CantidadVendida, vt.Fecha
	from Productos pr 
		inner join Ventas vt on (pr.IDProductos = vt.IDProductos)
		order by vt.CantidadVendida desc
	if @Filtro = 'Cantidad Productos Existentes'
	select pr.Titulo, pr.Descripcion, pr.Existencias
	from Productos pr 
		order by pr.Titulo
	if @Filtro = 'Cantidad Baja Inventario'
	select pr.Titulo, pr.Descripcion, pr.Existencias
	from Productos pr 
		where pr.Existencias < 100
		order by pr.Titulo
	end


