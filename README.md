# 5SneakerStore1
Приложение,онлайн-магазин, который специлизуется на продаже мужской обуви. Для реализации проекта будет использован C# в связке с MySQL.
Для выполнения работы данного приложение мне понадабятся следующие таблицы:

Users Table: This table will store information about all the users of the store. The columns can include:
+ UserID (Primary Key, Auto Increment)
+ UserName
+ UserEmail
+ UserPassword
+ UserAddress
+ UserPhoneNumber

Orders Table: This table will store information about all the orders placed by the users. The columns can include:
+ OrderID (Primary Key, Auto Increment)
+ UserID (Foreign Key)
+ OrderDate
+ OrderTotal
+ OrderStatus

OrderDetails Table: This table will store information about the individual products in each order. The columns can include:
+ OrderDetailID (Primary Key, Auto Increment)
+ OrderID (Foreign Key)
+ ProductID (Foreign Key)
+ Quantity
+ Price

Categories Table: This table will store information about the different categories of products available in the store. + The columns can include:
+ CategoryID (Primary Key, Auto Increment)
+ CategoryName
+ CategoryDescription

Reviews Table: This table will store information about the reviews and ratings given by the users for the products. The columns can include:
+ ReviewID (Primary Key, Auto Increment)
+ UserID (Foreign Key)
+ ProductID (Foreign Key)
+ Rating
+ ReviewText
+ ReviewDate

Wishlist Table: This table will store information about the products that a user has added to their wishlist. The columns can include:
+ WishlistID (Primary Key, Auto Increment)
+ UserID (Foreign Key)
+ ProductID (Foreign Key)

ShoppingCart Table: This table will store information about the products that a user has added to their shopping cart. The columns can include:
+ CartID (Primary Key, Auto Increment)
+ UserID (Foreign Key)
+ ProductID (Foreign Key)
+ Quantity
+ Price
