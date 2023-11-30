#INSERT INTO users (user_id, email, name) VALUES (1, 'random@gmail.com', 'randomName'); 
from faker import Faker
fake = Faker()

f = open("usersList.txt", "a")
for i in range(0,100,1):
    newName = fake.name()
    prenom = newName.split(" ")[0]
    nom = newName.split(" ")[1]
    f.write("INSERT INTO users (user_id, email, name) VALUES ({}, '{}.{}@gmail.com', '{} {}');\n".format(i, prenom, nom, prenom, nom))
f.close()