CREATE TABLE CustomerInfo(
	UserName VARCHAR2(16) PRIMARY KEY,
 	Password VARCHAR2(16) NOT NULL, 
	Address VARCHAR2(128),
	Credit NUMBER(8,2));

CREATE TABLE ProductInfo(
	ProductNo INT  PRIMARY KEY, 
	Price NUMBER(8,2) NOT NULL,
	Stock INT NOT NULL, 
	CONSTRAINT ProductInfo_Stock_chk CHECK(Stock>=0));

CREATE TABLE OrderDetail(
	OrderNo INT PRIMARY KEY, 
	OrderDate DATE NOT NULL, 
	CustomerId VARCHAR2(16), 
	ProductNo INT, 
	Quantity INT NOT NULL,
	CONSTRAINT OrderDetail_CustomerInfo_fk FOREIGN KEY(CustomerId) REFERENCES CustomerInfo(UserName), 
	CONSTRAINT OrderDetail_ProductInfo_fk FOREIGN KEY(ProductNo) REFERENCES ProductInfo(ProductNo), 
	CONSTRAINT OrderDetail_Quantity_chk CHECK(Quantity>0));

CREATE TABLE Counters(
	Id VARCHAR2(8) PRIMARY KEY, 
	CurrentValue INT NOT NULL,
	SeedValue INT NOT NULL);


INSERT INTO CustomerInfo VALUES ('CU401', 'PWD401', 'Mumbai 400099', 5000);
INSERT INTO CustomerInfo VALUES ('CU402', 'PWD402', 'Delhi 110047', 6000);
INSERT INTO CustomerInfo VALUES ('CU403', 'PWD403', 'Chennai 600027', 7000);

INSERT INTO ProductInfo VALUES (401, 350, 10);
INSERT INTO ProductInfo VALUES (402, 975, 20);
INSERT INTO ProductInfo VALUES (403, 845,30);
INSERT INTO ProductInfo VALUES (404, 1025, 40);

INSERT INTO OrderDetail VALUES(4001, '12-Jan-2017', 'CU401', 401, 5);
INSERT INTO OrderDetail VALUES(4002, '25-Jan-2018', 'CU403', 402, 10);
INSERT INTO OrderDetail VALUES(4003, '08-Feb-2019', 'CU402', 401, 12);
INSERT INTO OrderDetail VALUES(4004, '21-Mar-2020', 'CU401', 403, 3);
INSERT INTO OrderDetail VALUES(4005, '19-Mar-2021', 'CU402', 404, 15);

INSERT INTO Counters VALUES('product', 4, 400);
INSERT INTO Counters VALUES('order', 5, 4000);

COMMIT;

CREATE OR REPLACE PROCEDURE PlaceOrder(
    Customer VARCHAR2, 
    Product INT, 
    Quantity INT, 
    OrderId OUT INT) AS
BEGIN
    UPDATE Counters SET CurrentValue=CurrentValue+1 WHERE Id='order';
    SELECT CurrentValue+SeedValue INTO OrderId FROM Counters WHERE Id='order';
    INSERT INTO OrderDetail VALUES(OrderId, SYSDATE, Customer, Product, Quantity);
    COMMIT;
    EXCEPTION
    WHEN OTHERS THEN
    BEGIN
        ROLLBACK;
        RAISE;
    END;
END;
/

