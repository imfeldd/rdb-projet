#INSERT INTO ratings (user_id, title_id, does_recommand) VALUES (1, 1, true); 
import random

f = open("ratingsList.txt", "a")
for i in range(0,100,1):
    random.seed()
    nbrReview = random.randrange(8) + 3
    for j in range(0,nbrReview,1):
        reviewedFilm = random.randrange(5850)
        f.write("INSERT INTO ratings (user_id, title_id, does_recommend) VALUES ({}, {}, {});\n".format(i, reviewedFilm, random.random() > 0.5))
f.close()