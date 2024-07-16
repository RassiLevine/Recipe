-- replace //loginname// and //password// with secret values form vault
--IMPORTANT use master


drop login //loginname//
create login //loginname// with PASSWORD = //password//

--IMPORTANT

create user SQLdev_user from login //loginname//

alter role db_datareader add member SQLdev_user
alter role db_datawriter add member SQLdev_user