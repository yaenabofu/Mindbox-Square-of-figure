DROP TABLE IF EXISTS Category, Product, ProductsCategories;
CREATE TABLE Category 
(
	category_id int NOT NULL,
	description varchar(100) NULL,
	name varchar(40) NULL,
	PRIMARY KEY (category_id)
);
CREATE TABLE Product 
(
	product_id int NOT NULL,
	description varchar(100) NULL,
	name varchar(40) NULL,
	PRIMARY KEY (product_id)
);
CREATE TABLE ProductsCategories 
(
	id int NOT NULL,
	product_id int NOT NULL,
	category_id int NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (product_id) REFERENCES Product(product_id),
	FOREIGN KEY (category_id) REFERENCES Category(category_id),
);

INSERT INTO Category (category_id, description, name)
VALUES (1,'category1','name1');
INSERT INTO Category(category_id, description, name)
VALUES (2,'category2','name2');
INSERT INTO Category (category_id, description, name)
VALUES (3,'category3','name3');

INSERT INTO Product(product_id, description, name) 
VALUES (1,'product1','name1');
INSERT INTO Product (product_id, description, name)
VALUES (2,'product2','name2');

INSERT INTO ProductsCategories(id, product_id, category_id)
VALUES (1,1,1);
INSERT INTO ProductsCategories(id, product_id, category_id)
VALUES (2,1,2);
INSERT INTO ProductsCategories(id, product_id, category_id)
VALUES (3,1,3);

INSERT INTO ProductsCategories(id, product_id, category_id)
VALUES (4,2,1);
INSERT INTO ProductsCategories(id, product_id, category_id)
VALUES (5,2,2);
INSERT INTO ProductsCategories(id, product_id, category_id)
VALUES (6,2,null);
INSERT INTO ProductsCategories(id, product_id, category_id)
VALUES (7,2,3);
INSERT INTO ProductsCategories(id, product_id, category_id)
VALUES (8,1,null);

Select Product.name as 'Продукт', Category.name as 'Категория' from Product
inner join ProductsCategories on ProductsCategories.product_id = Product.product_id 
left join Category on Category.category_id = ProductsCategories.category_id;