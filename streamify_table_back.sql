DROP TYPE IF EXISTS title_type CASCADE;
CREATE TYPE title_type AS ENUM ('show', 'movie');
DROP TYPE IF EXISTS credit_role CASCADE;
CREATE TYPE credit_role AS ENUM('actor', 'director');

DROP TABLE IF EXISTS "titles" CASCADE;
CREATE TABLE "titles" (
  "title_id" serial PRIMARY KEY,
  "title" varchar,
  "type" title_type,
  "description" varchar,
  "release_year" integer,
  "age_certification" varchar,
  "runtime" integer,
  "seasons" integer
);

DROP TABLE IF EXISTS "title_genres" CASCADE;
CREATE TABLE "title_genres" (
  "title_id" integer,
  "genre_id" integer,
  PRIMARY KEY ("title_id", "genre_id")
);

DROP TABLE IF EXISTS "genres" CASCADE;
CREATE TABLE "genres" (
  "genre_id" serial PRIMARY KEY,
  "name" varchar
);

DROP TABLE IF EXISTS "person" CASCADE;
CREATE TABLE "person" (
  "person_id" serial PRIMARY KEY,
  "name" varchar
);

DROP TABLE IF EXISTS "title_credits" CASCADE;
CREATE TABLE "title_credits" (
  "person_id" integer,
  "title_id" integer,
  "character_name" varchar,
  "role" credit_role,
  PRIMARY KEY ("person_id", "title_id")
);

DROP TABLE IF EXISTS "users" CASCADE;
CREATE TABLE "users" (
  "user_id" serial PRIMARY KEY,
  "email" varchar,
  "name" varchar
);

DROP TABLE IF EXISTS "watchlists" CASCADE;
CREATE TABLE "watchlists" (
  "watch_id" serial PRIMARY KEY,
  "user_id" integer,
  "title_id" int,
  "viewed_at" date
);

DROP TABLE IF EXISTS "ratings" CASCADE;
CREATE TABLE "ratings" (
  "user_id" integer,
  "title_id" integer,
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