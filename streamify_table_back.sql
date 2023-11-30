CREATE TYPE title_type AS ENUM ('show', 'movie');
CREATE TYPE credit_role AS ENUM('actor', 'director');

CREATE TABLE "titles" (
  "title_id" varchar PRIMARY KEY,
  "title" varchar,
  "type" title_type,
  "description" varchar,
  "release_year" integer,
  "age_certification" varchar,
  "runtime" integer,
  "seasons" integer
);

CREATE TABLE "title_genres" (
  "title_id" varchar,
  "genre_id" integer,
  PRIMARY KEY ("title_id", "genre_id")
);

CREATE TABLE "genres" (
  "genre_id" integer PRIMARY KEY,
  "name" varchar
);

CREATE TABLE "person" (
  "person_id" varchar PRIMARY KEY,
  "name" varchar
);

CREATE TABLE "title_credits" (
  "person_id" varchar PRIMARY KEY,
  "title_id" varchar,
  "character_name" varchar,
  "role" credit_role
);

CREATE TABLE "users" (
  "user_id" integer PRIMARY KEY,
  "email" varchar,
  "name" varchar
);

CREATE TABLE "watchlists" (
  "watch_id" integer PRIMARY KEY,
  "user_id" integer,
  "title_id" varchar,
  "viewed_at" date
);

CREATE TABLE "ratings" (
  "user_id" integer,
  "title_id" varchar,
  "does_recommend" boolean,
  PRIMARY KEY ("user_id", "title_id")
);

ALTER TABLE "title_genres" ADD FOREIGN KEY ("title_id") REFERENCES "titles" ("title_id");

ALTER TABLE "title_genres" ADD FOREIGN KEY ("genre_id") REFERENCES "genres" ("genre_id");

ALTER TABLE "title_credits" ADD FOREIGN KEY ("person_id") REFERENCES "person" ("person_id");

ALTER TABLE "title_credits" ADD FOREIGN KEY ("title_id") REFERENCES "titles" ("title_id");

ALTER TABLE "watchlists" ADD FOREIGN KEY ("title_id") REFERENCES "titles" ("title_id");

ALTER TABLE "watchlists" ADD FOREIGN KEY ("user_id") REFERENCES "users" ("user_id");

ALTER TABLE "ratings" ADD FOREIGN KEY ("user_id") REFERENCES "users" ("user_id");

ALTER TABLE "ratings" ADD FOREIGN KEY ("title_id") REFERENCES "titles" ("title_id");
