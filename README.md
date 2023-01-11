ALTER TABLE orderitems ALTER COLUMN amount FLOAT
ALTER TABLE orderitems ALTER COLUMN batchnumber varchar(20) null
ALTER TABLE orderitems add constraint unq UNIQUE(batchnumber)
