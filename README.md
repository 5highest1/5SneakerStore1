# Building Materials Store
Приложение,онлайн-магазин, который специлизуется на продаже стройматериалов. Для реализации проекта будет использован C# в связке с MySQL.
Для выполнения работы данного приложение мне понадабятся следующие таблицы:

Users Table
+ UserID (Primary Key)
+ FirstName
+ LastName
+ Email
+ PasswordHash
+ PhoneNumber
+ Address
  
Products Table
+ ProductID (Primary Key)
+ Name
+ Description
+ Price
+ CategoryID (Foreign Key)
+ ImageURL

Categories Table
+ CategoryID (Primary Key)
+ Name

Orders Table
+ OrderID (Primary Key)
+ UserID (Foreign Key)
+ OrderDate
+ TotalPrice
+ Status

OrderDetails Table
+ OrderDetailID (Primary Key)
+ OrderID (Foreign Key)
+ ProductID (Foreign Key)
+ Quantity
+ Price

ShoppingCarts Table
+ ShoppingCartID (Primary Key)
+ UserID (Foreign Key)
+ ProductID (Foreign Key)
+ Quantity

