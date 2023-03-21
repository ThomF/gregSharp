CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS houses(
  id INT AUTO_INCREMENT PRIMARY KEY,
  title VARCHAR(50) NOT NULL COMMENT 'cool house moment',
  floors INT NOT NULL DEFAULT 1,
  bedrooms INT NOT NULL DEFAULT 1,
  bathrooms DOUBLE NOT NULL DEFAULT 1,
  squareFt INT NOT NULL DEFAULT 100,
  price INT NOT NULL DEFAULT 10000,
  description TEXT
)default charset utf8 COMMENT '';


INSERT INTO houses
(title, floors, bedrooms, bathrooms, squareFt, price, description)
VALUES
('Big ol Mansion', 1, 2, 2, 1200, 280000, 'This house is a big ol mansion but its olden times big')