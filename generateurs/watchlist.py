#INSERT INTO users (user_id, email, name) VALUES (1, 'random@gmail.com', 'randomName');
import random
import datetime
import random
from datetime import timedelta, datetime
f = open("watchlist.txt", "a")
def generate_random_dates(start_date, end_date, k):
    random_dates = []
    date_range = end_date - start_date
    for _ in range(k):
        random_days = random.randint(0, date_range.days)
        random_date = start_date + timedelta(days=random_days)
        random_dates.append(random_date)
    return random_dates
start_date = datetime(2020, 1, 1)
end_date = datetime(2023, 12, 1)
print(start_date)
random_dates = generate_random_dates(start_date, end_date, 1000)
print(type(random_dates))
print("The random dates generated are:")
fin = []
for index, date in enumerate(random_dates):
    fin.append(date.strftime('%Y-%m-%d'))
    print(f"{index+1}. {fin[index]}") 
print(len(fin))
for i in range(1,1000,1):

    f.write("INSERT INTO watchlists (watch_id, user_id, title_id, viewed_at) VALUES ({}, {}, {}, '{}');\n".format(i, random.randint(1,100), random.randint(1,5850), fin[i]))
f.close()
