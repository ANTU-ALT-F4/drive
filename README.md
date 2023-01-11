    ALTER TABLE orderitems ALTER COLUMN amount FLOAT
--------------------------------------------------------------------------------
    ALTER TABLE orderitems ALTER COLUMN batchnumber varchar(20) null
--------------------------------------------------------------------------------
    ALTER TABLE orderitems add constraint unq UNIQUE(batchnumber)
--------------------------------------------------------------------------------


    alter table TEACHER
       add constraint FK_TEACHER_WORK_AT_WORK_UNI foreign key (CODE_WORK_UNIT)
          references WORK_UNIT (CODE_WORK_UNIT)
    go
-------------------------------------------------------------------------------
    constraint fk_orderitems_orders foreign key (orderid) references orders(id)
-------------------------------------------------------------------------------
    id int identity(1,1) primary key
-------------------------------------------------------------------------------
    constraint PK_WORK_UNIT primary key (CODE_WORK_UNIT)
