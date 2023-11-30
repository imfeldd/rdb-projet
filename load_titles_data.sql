DROP TABLE IF EXISTS temp_credits;
CREATE TABLE temp_credits(
  person_id integer,
  id varchar,
  name varchar,
  character varchar,
  role varchar
);

COPY temp_credits(person_id, id, name, character, role)
FROM '/credits.csv'
DELIMITER ','
CSV HEADER;

DROP TABLE IF EXISTS temp_titles;
CREATE TABLE temp_titles(
  serial_id serial,
  id varchar,
  title varchar,
  type varchar,
  description varchar,
  release_year integer,
  age_certification varchar,
  runtime integer,
  genres varchar,
  production_countries varchar,
  seasons decimal,
  imdb_id varchar,
  imdb_score varchar,
  imdb_votes varchar,
  tmdb_popularity varchar,
  tmdb_score varchar
);

COPY temp_titles(id,title,type,description,release_year,age_certification,runtime,genres,production_countries,seasons,imdb_id,imdb_score,imdb_votes,tmdb_popularity,tmdb_score)
FROM '/titles.csv'
DELIMITER ','
CSV HEADER;

-- Insert titles
INSERT INTO titles(title_id, title, type, description, release_year, age_certification, runtime, seasons)
SELECT serial_id, title, lower(type)::title_type, description, release_year, age_certification, runtime, seasons
FROM temp_titles;

-- Insert persons
INSERT INTO person(person_id, name)
SELECT person_id, name
FROM temp_credits
GROUP BY person_id, name;

-- Insert title credits 
INSERT INTO title_credits(person_id, title_id, character_name, role)
SELECT person_id, tt.serial_id, character, lower(role)::credit_role
FROM temp_credits
INNER JOIN temp_titles tt ON tt.id = temp_credits.id;

-- Clean temporary tables
DROP TABLE temp_titles;
DROP TABLE temp_credits;