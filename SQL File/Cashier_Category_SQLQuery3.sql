SELECT * FROM Categories;

SELECT * FROM Products;

CREATE TABLE orders
(
     id int PRIMARY   KEY IDENTITY(1,1),
    
     prod_id VARCHAR (255) NOT NULL,
     prod_name varchar(255) NOT NULL,
     category varchar(255) NOT NULL,
     qty int NOT NULL,
     orig_price float NOT NULL,
    total_price float NOT NULL,
     order_date DATE NOT NULL,

)

alter table orders
add customer_id int NOT NULL;


SELECT * FROM orders;

CREATE TABLE customers
(
     id int PRIMARY   KEY IDENTITY(1,1),
    customer_id int NOT NULL,
    prod_id varchar(Max) not null,
    total_price float not null,
    amount float not null,
    change float not null,
    order_date Date not null,

)

select * from customers

