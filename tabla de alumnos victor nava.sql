--#tabla de alumnos

CREATE TABLE alumnos (
    first_name VARCHAR (50),
    age INT,
    gender VARCHAR (50)

);

INSERT INTO alumnos (first_name, age, gender) VALUES
("Victor", 24, "masculino"),
("Nestor", 17, "masculino"),
("Darwin", 17, "masculino");


ALTER TABLE alumnos
DROP COLUMN age;

ALTER TABLE alumnos
ADD COLUMN profesion VARCHAR (50);