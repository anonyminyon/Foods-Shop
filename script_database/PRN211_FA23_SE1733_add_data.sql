-- Sample data for Categories_HE171691 table (Vegetables and Fruits)
INSERT INTO Categories_HE171691 (categoriesName)
VALUES
    ('Vegetables'),
    ('Fruits');
GO
-- Sample data for Product_HE171691 table (vegetable and fruit products)
INSERT INTO Product_HE171691 (productName, price, Categories_categoriesID, Description, stockQuantity)
VALUES
    ('Tomatoes', 1.99, 1, 'Fresh and juicy tomatoes.', 100),
    ('Carrots', 1.49, 1, 'Crunchy and nutritious carrots.', 150),
    ('Spinach', 2.99, 1, 'Healthy and leafy green spinach.', 75),
    ('Apples', 1.49, 2, 'Crispy and sweet apples.', 100),
    ('Bananas', 0.99, 2, 'Ripe and ready-to-eat bananas.', 150),
    ('Oranges', 1.99, 2, 'Juicy and fresh oranges.', 75);
GO
-- Sample data for Account_HE171691 table
INSERT INTO Account_HE171691 (email, password, userName, address, phoneNumber)
VALUES
    ('user1@example.com', 'password1', 'User One', '123 Main St', '555-111-1111'),
    ('user2@example.com', 'password2', 'User Two', '456 Elm St', '555-222-2222'),
    ('user3@example.com', 'password3', 'User Three', '789 Oak St', '555-333-3333');
GO