CREATE TABLE [dbo].[OrderManager] (
    [Order ID]      UNIQUEIDENTIFIER NOT NULL,
    [Size]          VARCHAR(50)       NOT NULL,
    [Crust]         VARCHAR(50)       NOT NULL,
    [Sausage]       BIT       NOT NULL,
    [Pepperoni]     BIT       NOT NULL,
    [Onions]        BIT       NOT NULL,
    [Green Peppers] BIT       NOT NULL,
    [Total Cost]    VARCHAR(50)       NOT NULL,
    [Name]          VARCHAR(50)       NOT NULL,
    [Address]       VARCHAR(50)       NOT NULL,
    [Zip]           VARCHAR(50)       NOT NULL,
    [Phone]         VARCHAR(50)       NOT NULL,
    [PaymentType]   VARCHAR(50)       NOT NULL,
    [Completed]     BIT       NULL ,
    PRIMARY KEY CLUSTERED ([Order ID] ASC)
);

