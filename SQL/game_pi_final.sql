DROP SCHEMA IF EXISTS percussion_island3;
CREATE SCHEMA percussion_island3;
USE percussion_island3;

CREATE TABLE game_user (
  user_id SMALLINT UNSIGNED NOT NULL AUTO_INCREMENT,
  user_name VARCHAR(45) NOT NULL,
  pwd VARCHAR(45) NOT NULL,
  date_joined date not null default (current_date),
  PRIMARY KEY  (user_id),
  KEY idx_user_name (user_name),
  UNIQUE KEY `user_name_UNIQUE` (user_name)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

create table questions (
	question_id smallint unsigned not null auto_increment,
    question varchar(100) not null,
    cor_answer varchar(50) not null,
    answer_2 varchar(50) not null,
    answer_3 varchar(50) not null,
    answer_4 varchar(50) not null,
    primary key (question_id)
)   ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


create table game_user_scores(
	user_id smallint unsigned not null,
	rhythm_best_score smallint unsigned not null default 0,
    rhythm_last_score smallint unsigned not null default 0,
    rhythm_play_time time not null default ("00:00:00"),
    trivia_best_score smallint unsigned not null default 0,
    trivia_last_score smallint unsigned not null default 0,
    trivia_play_time time not null default ("00:00:00"),
    memory_best_score smallint unsigned not null default 0,
    memory_last_score smallint unsigned not null default 0,
    memory_play_time time not null default ("00:00:00"),
    memorysounds_best_score smallint unsigned not null default 0,
    memorysounds_last_score smallint unsigned not null default 0,
    memorysounds_play_time time not null default ("00:00:00"),
    primary key (user_id),
    CONSTRAINT `fk_user_scores` FOREIGN KEY (user_id) REFERENCES game_user (user_id) ON DELETE RESTRICT ON UPDATE CASCADE

)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

create table game_user_key_inventory(
	user_id smallint unsigned not null,
    key_item_name varchar(45) not null,
    primary key (user_id),
    CONSTRAINT `fk_user_inventory` FOREIGN KEY (user_id) REFERENCES game_user (user_id) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

create table game_user_save_file(
	user_id smallint unsigned not null,
    key_instruments_unlocked tinyint unsigned not null default 0,
    player_position_x float not null,
    player_position_y float not null,
    primary key(user_id),
    CONSTRAINT `fk_user_savefile` FOREIGN KEY (user_id) REFERENCES game_user (user_id) ON DELETE RESTRICT ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;