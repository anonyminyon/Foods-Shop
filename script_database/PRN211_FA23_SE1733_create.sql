-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2023-10-26 03:53:39.847

-- tables
-- Table: Account_HE171691
CREATE TABLE Account_HE171691 (
    accID int  NOT NULL IDENTITY(1, 1),
    email varchar(225)  NOT NULL,
    password nvarchar(225)  NOT NULL,
    userName nvarchar(225)  NULL,
    address nvarchar(max)  NULL,
    phoneNumber varchar(50)  NULL,
    CONSTRAINT Account_HE171691_pk PRIMARY KEY  (accID)
);
GO
-- Table: Categories_HE171691
CREATE TABLE Categories_HE171691 (
    categoriesID int  NOT NULL IDENTITY(1, 1),
    categoriesName nvarchar(225)  NOT NULL,
    CONSTRAINT Categories_HE171691_pk PRIMARY KEY  (categoriesID)
);
GO
-- Table: ImageProduct_HE171691
CREATE TABLE ImageProduct_HE171691 (
    imageID int  NOT NULL IDENTITY(1, 1),
    Product_productID int  NOT NULL,
    imagePath int  NOT NULL,
    CONSTRAINT ImageProduct_HE171691_pk PRIMARY KEY  (imageID)
);
GO
-- Table: OrderDetails_HE171691
CREATE TABLE OrderDetails_HE171691 (
    orderdetailID int  NOT NULL,
    quantity float  NULL,
    unitPrice float  NULL,
    subTotal float  NULL,
    Orders_orderID int  NOT NULL,
    Product_productID int  NOT NULL,
    CONSTRAINT OrderDetails_HE171691_pk PRIMARY KEY  (orderdetailID)
);
GO
-- Table: Orders_HE171691
CREATE TABLE Orders_HE171691 (
    orderID int  NOT NULL IDENTITY(1, 1),
    orderDate datetime  NULL,
    totalAmount int  NULL,
    Account_accID int  NOT NULL,
    CONSTRAINT Orders_HE171691_pk PRIMARY KEY  (orderID)
);
GO
-- Table: Product_HE171691
CREATE TABLE Product_HE171691 (
    productID int  NOT NULL IDENTITY(1, 1),
    productName nvarchar(225)  NOT NULL,
    price float  NULL,
    Categories_categoriesID int  NOT NULL,
    Description nvarchar(max)  NULL,
    stockQuantity float  NULL,
    CONSTRAINT Product_HE171691_pk PRIMARY KEY  (productID)
);
GO
-- foreign keys
-- Reference: Image_HE171691_Product_HE171691 (table: ImageProduct_HE171691)
ALTER TABLE ImageProduct_HE171691 ADD CONSTRAINT Image_HE171691_Product_HE171691
    FOREIGN KEY (Product_productID)
    REFERENCES Product_HE171691 (productID);
GO
-- Reference: OrderDetails_HE171691_Orders_HE171691 (table: OrderDetails_HE171691)
ALTER TABLE OrderDetails_HE171691 ADD CONSTRAINT OrderDetails_HE171691_Orders_HE171691
    FOREIGN KEY (Orders_orderID)
    REFERENCES Orders_HE171691 (orderID);
GO
-- Reference: OrderDetails_HE171691_Product_HE171691 (table: OrderDetails_HE171691)
ALTER TABLE OrderDetails_HE171691 ADD CONSTRAINT OrderDetails_HE171691_Product_HE171691
    FOREIGN KEY (Product_productID)
    REFERENCES Product_HE171691 (productID);
GO
-- Reference: Orders_HE171691_Account_HE171691 (table: Orders_HE171691)
ALTER TABLE Orders_HE171691 ADD CONSTRAINT Orders_HE171691_Account_HE171691
    FOREIGN KEY (Account_accID)
    REFERENCES Account_HE171691 (accID);
GO
-- Reference: Product_HE171691_Categories_HE171691 (table: Product_HE171691)
ALTER TABLE Product_HE171691 ADD CONSTRAINT Product_HE171691_Categories_HE171691
    FOREIGN KEY (Categories_categoriesID)
    REFERENCES Categories_HE171691 (categoriesID);
GO
-- End of file.

