CREATE TABLE accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE chores(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  difficulty INT NOT NULL DEFAULT 5, 
  name VARCHAR(50) NOT NULL,
  color VARCHAR(50) NOT NULL,
  isDone BOOLEAN DEFAULT false,
  isUrgent BOOLEAN DEFAULT false
);

INSERT INTO chores(name, difficulty, color, isDone, isUrgent) VALUES("Make Dinner", 6, "orange", false, false);

INSERT INTO chores(name, difficulty, color, isDone, isUrgent) 
  VALUES
  ("Journal Assignments", 4, "green", false, false);
  ("Sleep", 2, "blue", false, true);

