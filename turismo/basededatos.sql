CREATE TABLE users (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  name TEXT,
  email TEXT
);
CREATE DATABASE mydatabase;

USE mydatabase;

CREATE TABLE users (
  id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(50),
  email VARCHAR(100)
);
INSERT INTO users (name, email) VALUES ('John Doe', 'chiapperoleyria07@gmail.com');
SELECT * FROM users;
