`ALTER TABLE orderitems ALTER COLUMN amount FLOAT`

`ALTER TABLE orderitems ALTER COLUMN batchnumber varchar(20) null`

`ALTER TABLE orderitems add constraint unq UNIQUE(batchnumber)`

`constraint fk_pk1_pk2 foreign key (departmentid) references departments(id) ON DELETE CASCADE ON UPDATE CASCADE`

`constraint fk_orderitems_orders foreign key (orderid) references orders(id)`

`id int identity(1,1) primary key`
