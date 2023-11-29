CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS recipes (
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        title VARCHAR(255) NOT NULL,
        instructions VARCHAR(255) NOT NULL,
        img BLOB(1000) NOT NULL,
        category ENUM(
            "Pizza",
            "Wings",
            "Pasta",
            "Burger",
            "Steak"
        ) NOT NULL -- FOREIGN KEY (creatorId) REFERENCES accounts(id)
    ) default charset utf8 COMMENT '';

INSERT INTO
    recipes(
        title,
        instructions,
        img,
        category
    )
VALUES (
        "Fives Guys",
        "Burger",
        "https://www.google.com/imgres?imgurl=https%3A%2F%2Flookaside.fbsbx.com%2Flookaside%2Fcrawler%2Fmedia%2F%3Fmedia_id%3D100089631741559&tbnid=_PYBUq7Y-teoqM&vet=12ahUKEwjN4JyHreqCAxWlJzQIHVzJDowQMygEegQIARB3..i&imgrefurl=https%3A%2F%2Fwww.facebook.com%2FFiveGuysMilwaukeeStBoiseID%2F&docid=C1rXthxndO-1ZM&w=771&h=771&q=fiveguys&ved=2ahUKEwjN4JyHreqCAxWlJzQIHVzJDowQMygEegQIARB3",
        "Burger"
    )

DROP TABLE recipe;