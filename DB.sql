CREATE TABLE `programas` (
	`ID` BIGINT(20) NOT NULL AUTO_INCREMENT,
	`Programa` VARCHAR(1000) NOT NULL COLLATE 'latin1_swedish_ci',
	`WebSite` VARCHAR(2000) NULL DEFAULT NULL COLLATE 'latin1_swedish_ci',
	`Instalado` BIT(1) NOT NULL,
	`Fecha_Hora` DATETIME NOT NULL,
	`Imagen` LONGBLOB NULL DEFAULT NULL,
	PRIMARY KEY (`ID`) USING BTREE
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB
;