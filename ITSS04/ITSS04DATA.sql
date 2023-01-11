CREATE DATABASE ITSS04
GO
USE ITSS04
GO

CREATE TABLE suppliers
( id int identity(1,1) primary key,
  name varchar(100)
)

CREATE TABLE warehouses
( id int identity(1,1) primary key,
  name varchar(100)
)

CREATE TABLE transactiontype(
	id int identity(1,1) primary key,
	name varchar(100)
)

CREATE TABLE parts
(	id int identity(1,1) primary key,
	name varchar(100),
	effectivelife varchar(100),
	batchnumberhasrequired int,
	minimumamount int
)

CREATE TABLE orders 
(	id int identity(1,1) primary key,
	transactiontypeid int,
	suppliersid int,
	sourcewarehouseid int,
	destinationwarehouseid int,
	date date,
	constraint fk_1 foreign key (transactiontypeid) references transactiontype(id),
	constraint fk_2 foreign key (suppliersid) references suppliers(id),
	constraint fk_3 foreign key (sourcewarehouseid) references warehouses(id),
	constraint fk_4 foreign key (destinationwarehouseid) references warehouses(id)
)
go

CREATE TABLE orderitems
( id int identity(1,1) primary key,
  orderid int,
  partid int,
  batchnumber varchar(20),
  amount FLOAT,
  constraint fk_5 foreign key (orderid) references orders(id),
  constraint fk_6 foreign key (partid) references parts(id)
)

 insert into suppliers (name) values('Nha_Cung_Cap_1'),
									('Nha_Cung_Cap_2'),
									('Nha_Cung_Cap_3'),
									('Nha_Cung_Cap_4'),
									('Nha_Cung_Cap_5')

 insert into warehouses(name) values ('Kho_Hang_1'),
								     ('Kho_Hang_2'),
								     ('Kho_Hang_3'),
								     ('Kho_Hang_4'),
								     ('Kho_Hang_5') 

insert into transactiontype(name) values ('Purchase Order'),
										 ('Warehouse Management')

insert into parts(name, effectivelife, batchnumberhasrequired, minimumamount )
values ('Bo_Phan_1', 'effectivelife_1', 1, 20000 ),
		('Bo_Phan_2', 'effectivelife_2', 0, 20000 ),
		('Bo_Phan_3', 'effectivelife_3', 1, 10000 ),
		('Bo_Phan_4', 'effectivelife_4', 1, 30000 ),
		('Bo_Phan_5', 'effectivelife_5', 0, 50000 )

ALTER TABLE orderitems ALTER COLUMN amount FLOAT
ALTER TABLE orderitems ALTER COLUMN batchnumber varchar(20) null
ALTER TABLE orderitems add constraint unq UNIQUE(batchnumber)
UPDATE orderitems SET batchnumber = 'BA02' WHERE id = 2

Select * from [dbo].[orderitems]
Select * from [dbo].[orders]
Select * from [dbo].[parts]
Select * from [dbo].[suppliers]
Select * from [dbo].[transactiontype]
Select * from [dbo].[warehouses]

delete from orderitems
delete from [orders]

SELECT orders.id AS idorderitems, parts.name AS partname, transactiontype.name AS transactiontype, orders.date, SUM(orderitems.amount) AS amount,nhap.name as source,chuyenden.name as destination
FROM transactiontype,suppliers,parts,orderitems
INNER JOIN orders ON orders.id = orderitems.orderid
LEFT JOIN warehouses as nhap ON nhap.id = orders.sourcewarehouseid
LEFT JOIN warehouses as chuyenden ON chuyenden.id = orders.destinationwarehouseid
WHERE orders.transactiontypeid = transactiontype.id
AND orders.suppliersid = suppliers.id
AND orderitems.partid = parts.id
GROUP BY orders.id, parts.name, transactiontype.name, orders.date, orders.sourcewarehouseid,orders.destinationwarehouseid,nhap.name,chuyenden.name
ORDER BY DAY(orders.date) ASC,idorderitems DESC

Select suppliersid,sourcewarehouseid from orders where id = 27

Select sourcewarehouseid,destinationwarehouseid from orders where id = '1'

