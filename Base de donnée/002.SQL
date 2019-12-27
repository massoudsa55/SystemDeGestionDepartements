DROP DATABASE IF EXISTS gestion_de_departement;

CREATE DATABASE IF NOT EXISTS gestion_de_departement;
USE gestion_de_departement;
# -----------------------------------------------------------------------------
#       TABLE : USER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS USER
 (
   ID_USER INT(20) NOT NULL AUTO_INCREMENT ,
   NOM_USER VARCHAR(50) NOT NULL ,
   ID_TYPE_USER VARCHAR(50) NOT NULL  ,
   PASSWORD VARCHAR(50) NULL  
   , PRIMARY KEY (ID_USER) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `user` (`ID_USER`, `NOM_USER`, `ID_TYPE_USER`, `PASSWORD`) 
 VALUES 
 ('1' , 'admin', 'Administration', '123'), 
 ('2' , 'etud', 'Etudiants', '123'), 
 ('3' , 'ens', 'Enseignants', '123');

# -----------------------------------------------------------------------------
#       TABLE : FLIERES
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS FLIERES
 (
   ID_FILIERE VARCHAR(20) NOT NULL  ,
   ID__DEPARTEMENT VARCHAR(20) NOT NULL  ,
   NOM_FILIERE VARCHAR(50) NULL  
   , PRIMARY KEY (ID_FILIERE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `flieres` (`ID_FILIERE`, `ID__DEPARTEMENT`, `NOM_FILIERE`) 
 VALUES 
 ('D03', 'DPR001', 'Mathématique et informatique');

# -----------------------------------------------------------------------------
#       TABLE : ETUDIANT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ETUDIANT
 (
   ID_ETUDIANT VARCHAR(20) NOT NULL  ,
   ID_SPECIALITE VARCHAR(20) NOT NULL  ,
   ID_USER INT(20)  NULL  ,
   ID_GROUPE VARCHAR(20) NOT NULL  ,
   NOM_ETUDIANT VARCHAR(50) NULL  ,
   PRENOM_ETUDIANT VARCHAR(50) NULL  ,
   DATA_DE_NAISSANCE DATE NULL  ,
   LIEN_DE_NAISSANCE VARCHAR(60) NULL  ,
   ADRESS_ETUDIANT VARCHAR(60) NULL  ,
   EMAIL_ETUDIANT VARCHAR(60) NULL  ,
   TELEPHONE_ETUDIANT INTEGER(20) NULL  ,
   ANNEE_ETUD DATE NULL  ,
   PASSWORD VARCHAR(50) NULL  
   , PRIMARY KEY (ID_ETUDIANT) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;
 
 
INSERT INTO `etudiant` (`ID_ETUDIANT`, `ID_SPECIALITE`, `ID_USER`, `ID_GROUPE`, 
`NOM_ETUDIANT`, `PRENOM_ETUDIANT`, `DATA_DE_NAISSANCE`, `LIEN_DE_NAISSANCE`, 
`ADRESS_ETUDIANT`, `EMAIL_ETUDIANT`, `TELEPHONE_ETUDIANT`, `ANNEE_ETUD`, `PASSWORD`) 
VALUES 
('ETD001', 'SPE3I', NULL, 'GRP3IG2', 'Benkouider', 'Massoud', '2017-03-06', 'DARCHIOUKH', 
'DARCHIOUKH', 'massoudsa55@gmail.com', '0698672776', '2018-05-12', NULL), 
('ETD002', 'SPE3I', NULL, 'GRP3IG2', 'Bengahtani', 'Oussama', '2018-03-26', 'DARCHIOUKH', 
'DARCHIOUKH', 'oussamabengahtani@gmail.com', '0699928784', '2018-03-21', NULL), 
('ETD003', 'SPE3I', NULL, 'GRP3IG2', 'Bakhti', 'Yacine', '2018-03-07', 'HASSIBAHBAH', 
'HASSIBAHBAH', 'yacinebakhti1mi@gmail.com', '0799672776', '2018-03-19', NULL),
('ETD004', 'SPE3M', NULL, 'GRP3MG1', 'Birech', 'Brahim', '2018-04-20', 'Djelfa', 
'Djelfa', 'xxx@gmail.vom', NULL, '2018-04-19', NULL), ('ETD005', 'SPE3I', NULL, 'GRP3IG2', 'Facih', 'Mostafa', '1996-04-20', 'Djelfa', 
'Djelfa', 'facih@gmail.vom', NULL, '2015-04-19', NULL);


# -----------------------------------------------------------------------------
#       TABLE : GROUPE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS GROUPE
 (
   ID_GROUPE VARCHAR(20) NOT NULL  ,
   NOM_GROUPE VARCHAR(50) NULL  
   , PRIMARY KEY (ID_GROUPE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 

INSERT INTO `groupe` (`ID_GROUPE`, `NOM_GROUPE`) 
VALUES
 ('GRP2MG1', 'G1'), ('GRP2MG2', 'G2'), ('GRP2MG3', 'G2'), 
 ('GRP2IG1', 'G1'), ('GRP2IG2', 'G2'), ('GRP2IG3', 'G3'), 
 ('GRP3MG1', 'G1'), ('GRP3MG2', 'G2'), ('GRP3MG3', 'G3'), 
 ('GRP3IG1', 'G1'), ('GRP3IG2', 'G2'), ('GRP3IG3', 'G3'), 
 ('GRP1MIA1', 'A1'), ('GRP1MIA2', 'A2'), ('GRP1MIA3', 'A3'), ('GRP1MIA4', 'A4'), 
 ('GRP1MIA5', 'A5'), ('GRP1MIA6', 'A6'), ('GRP1MIB1', 'B1'), ('GRP1MIB2', 'B2'), 
 ('GRP1MIB3', 'B3'), ('GRP1MIB4', 'B4'), ('GRP1MIB5', 'B5'), ('GRP1MIB6', 'B6');

# -----------------------------------------------------------------------------
#       TABLE : DEPARTEMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DEPARTEMENT
 (
   ID__DEPARTEMENT VARCHAR(20) NOT NULL  ,
   NOM__DEPARTEMENT VARCHAR(50) NULL  
   , PRIMARY KEY (ID__DEPARTEMENT) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `departement` (`ID__DEPARTEMENT`, `NOM__DEPARTEMENT`) 
 VALUES 
 ('DPR001', 'Science exacte et informatique');

# -----------------------------------------------------------------------------
#       TABLE : SECTION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SECTION
 (
   ID_SECTION VARCHAR(20) NOT NULL  ,
   ID_GROUPE VARCHAR(20) NULL  ,
   NOM_SECTION VARCHAR(50) NULL  
   , PRIMARY KEY (ID_SECTION) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `section` (`ID_SECTION`, `ID_GROUPE`, `NOM_SECTION`) 
 VALUES 
 ('SECA001', 'GRP1MIA1', 'SecstionA'),
 ('SECA002', 'GRP1MIA2', 'SecstionA'),
 ('SECA003', 'GRP1MIA3', 'SecstionA'),
 ('SECA004', 'GRP1MIA4', 'SecstionA'),
 ('SECA005', 'GRP1MIA5', 'SecstionA'),
 ('SECA006', 'GRP1MIA6', 'SecstionA'),
 ('SECB001', 'GRP1MIB1', 'SecstionB'),
 ('SECB002', 'GRP1MIB2', 'SecstionB'),
 ('SECB003', 'GRP1MIB3', 'SecstionB'),
 ('SECB004', 'GRP1MIB4', 'SecstionB'),
 ('SECB005', 'GRP1MIB5', 'SecstionB'),
 ('SECB006', 'GRP1MIB6', 'SecstionB');

# -----------------------------------------------------------------------------
#       TABLE : SEMESTRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SEMESTRE
 (
   NOM_SEMESTRE VARCHAR(20) NOT NULL  ,
   ANNEE_UNIV DATE NULL  
   , PRIMARY KEY (NOM_SEMESTRE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `semestre` (`NOM_SEMESTRE`, `ANNEE_UNIV`) 
 VALUES 
 ('Semestre1', '2018-03-01'), 
 ('Semestre2', '2018-03-01');

# -----------------------------------------------------------------------------
#       TABLE : SPECIALITE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SPECIALITE
 (
   ID_SPECIALITE VARCHAR(20) NOT NULL  ,
   ID_FILIERE VARCHAR(20) NOT NULL  ,
   NOM_SPECIALITE VARCHAR(50) NULL  ,
   NIVEAU INTEGER(20) NULL  
   , PRIMARY KEY (ID_SPECIALITE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `specialite` (`ID_SPECIALITE`, `ID_FILIERE`, `NOM_SPECIALITE`, `NIVEAU`) 
 VALUES 
 ('SPE1MI', 'D03', 'MI', '1'), ('SPE2M', 'D03', 'Math', '2'), 
 ('SPE2I', 'D03', 'Info', '2'), ('SPE3M', 'D03', 'Math', '3'), 
 ('SPE3I', 'D03', 'Info', '3'), ('SPE1MASTRE', 'D03', 'Mastre', '1'),
 ('SPE2MASTRE', 'D03', 'Mastre', '2') ;

# -----------------------------------------------------------------------------
#       TABLE : MODULE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MODULE
 (
   ID_MODULE VARCHAR(20) NOT NULL  ,
   ID_UNITE_ENSEIGNER VARCHAR(32) NOT NULL  ,
   ID_TYPE_MODULE VARCHAR(20) NULL  ,
   NOM_MODULE VARCHAR(50) NULL  ,
   COEFFICIENT_MODULE INTEGER(2) NULL  
   , PRIMARY KEY (ID_MODULE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `module` (`ID_MODULE`, `ID_UNITE_ENSEIGNER`, `ID_TYPE_MODULE`, `NOM_MODULE`, `COEFFICIENT_MODULE`) 
 VALUES 
 ('MOD001', 'UEF007', 'Cours', 'Application Mobile', '3'), 
 ('MOD002', 'UEF007', 'Cours', 'Sécurity informatique', '3'), 
 ('MOD003', 'UEF008', 'Cours', 'Cryptographie', '2'), 
 ('MOD004', 'UEF008', 'Cours', 'Infographie', '2'), 
 ('MOD005', 'UT2', 'Cours', 'Rédaction scientifique', '1');

# -----------------------------------------------------------------------------
#       TABLE : UNITE_ENSEIGNER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS UNITE_ENSEIGNER
 (
   ID_UNITE_ENSEIGNER VARCHAR(32) NOT NULL  ,
   ID_TYPE_ENITE VARCHAR(20) NOT NULL  ,
   COEFFICIENT INTEGER(2) NULL  
   , PRIMARY KEY (ID_UNITE_ENSEIGNER) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `unite_enseigner` (`ID_UNITE_ENSEIGNER`, `ID_TYPE_ENITE`, `COEFFICIENT`) 
 VALUES 
 ('UEF001', 'UEF', '10'), ('UEF002', 'UEF', '5'), ('UEF003', 'UEF', '7'), 
 ('UEF004', 'UEF', '8'), ('UEF005', 'UEF', '7'), ('UEF006', 'UEF', '7'), 
 ('UED001', 'UED', '4'), ('UEM001', 'UEM', '2'), ('UEM002', 'UEM', '3'), 
 ('UEM003', 'UEM', '1'), ('UEM004', 'UEM', '2'), ('UET001', 'UET', '1'), 
 ('UET002', 'UET', '3'), ('UEF007', 'UEF', '6'), ('UEF008', 'UEF', '4'), 
 ('UT1', 'UT', '1'), ('UT2', 'UT', '1'), ('UM2', 'UM', '4');

# -----------------------------------------------------------------------------
#       TABLE : TYPE_MODULE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_MODULE
 (
   ID_TYPE_MODULE VARCHAR(20) NOT NULL  
   , PRIMARY KEY (ID_TYPE_MODULE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `type_module` (`ID_TYPE_MODULE`) 
 VALUES 
 ('Cours'), 
 ('TD'), 
 ('TP');
 
# -----------------------------------------------------------------------------
#       TABLE : SALLE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SALLE
 (
   NOM_SALLE VARCHAR(20) NOT NULL  ,
   CAPACITE INTEGER(3) NULL  
   , PRIMARY KEY (NOM_SALLE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `salle` (`NOM_SALLE`, `CAPACITE`) 
 VALUES 
 ('Salle01', '40'), ('Salle02', '45'), 
 ('Salle03', '50'), ('Salle04', '50'), 
 ('Salle05', '40'), ('Salle06', '40'), 
 ('Salle07', '40'), ('Salle08', '45'), 
 ('AmphiA', '100'), ('AmphiB', '100');

# -----------------------------------------------------------------------------
#       TABLE : TYPE_USER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_USER
 (
   ID_TYPE_USER VARCHAR(50) NOT NULL  
   , PRIMARY KEY (ID_TYPE_USER) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `type_user` (`ID_TYPE_USER`) 
 VALUES 
 ('Administration'), 
 ('Etudiants'), 
 ('Enseignants');

# -----------------------------------------------------------------------------
#       TABLE : TYPE_ENITE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_ENITE
 (
   ID_TYPE_ENITE VARCHAR(20) NOT NULL  ,
   NOM_TYPE_ENITE VARCHAR(50) NULL  
   , PRIMARY KEY (ID_TYPE_ENITE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 INSERT INTO `type_enite` (`ID_TYPE_ENITE`, `NOM_TYPE_ENITE`) 
 VALUES 
 ('UEF', 'Fondamentale'), 
 ('UED', 'Découverte'), 
 ('UEM', 'Méthodologique'), 
 ('UET', 'Transeversate'),
 ('UM', 'Projet de fin d\'études'), 
 ('UT', 'Rédaction scientifique');
 
# -----------------------------------------------------------------------------
#       TABLE : ENSEIGNANT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ENSEIGNANT
 (
   ID_ENSEIGNANT VARCHAR(20) NOT NULL  ,
   ID_USER INT(20) NULL  ,
   NOM_ENSEIGNANT VARCHAR(50) NULL  ,
   PRENOM_ENSEIGNANT VARCHAR(50) NULL  ,
   DATA_DE_NAISSANCE DATE NULL  ,
   LIEN_DE_NAISSANCE VARCHAR(60) NULL  ,
   ADRESS_ENSEIGNANT VARCHAR(60) NULL  ,
   EMAIL_ENSEIGNANT VARCHAR(60) NULL  ,
   TELEPHONE_ENSEIGNANT INTEGER(20) NULL  ,
   GRADE_ENSEIGNANT VARCHAR(30) NULL  ,
   PASSWORD VARCHAR(50) NULL  
   , PRIMARY KEY (ID_ENSEIGNANT) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;
 
 INSERT INTO `enseignant` (`ID_ENSEIGNANT`, `ID_USER`, `NOM_ENSEIGNANT`, 
 `PRENOM_ENSEIGNANT`, `DATA_DE_NAISSANCE`, `LIEN_DE_NAISSANCE`, `ADRESS_ENSEIGNANT`, `EMAIL_ENSEIGNANT`, 
 `TELEPHONE_ENSEIGNANT`, `GRADE_ENSEIGNANT`, `PASSWORD`) 
 VALUES 
 ('ENS001', NULL, 'Benmassoud','Abdelkhader','1975-03-06', 'DARCHIOUKH', 'Djelfa', 'benmassoud@gmail.com', NULL, 'prof', NULL), 
 ('ENS002', NULL, 'Bessine', 'Karima','1989-03-07', 'DARCHIOUKH', 'Oussara', 'bessine@gmail.com', NULL, 'prof', NULL);

# -----------------------------------------------------------------------------
#       TABLE : ENSIGNE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ENSIGNE
 (
   ID_ENSEIGNANT VARCHAR(20) NOT NULL  ,
   ID_GROUPE VARCHAR(20) NOT NULL  ,
   ID_MODULE VARCHAR(20) NOT NULL  
   , PRIMARY KEY (ID_ENSEIGNANT,ID_GROUPE,ID_MODULE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;
 
 INSERT INTO `ensigne` (`ID_ENSEIGNANT`, `ID_GROUPE`, `ID_MODULE`) 
 VALUES 
 ('ENS001', 'GRP3IG1', 'MOD001'), ('ENS001', 'GRP3IG2', 'MOD001'), 
 ('ENS001', 'GRP3IG3', 'MOD001'), ('ENS002', 'GRP3IG1', 'MOD005'), 
 ('ENS002', 'GRP3IG2', 'MOD005'), ('ENS002', 'GRP3IG3', 'MOD005');

# -----------------------------------------------------------------------------
#       TABLE : NOTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS NOTE
 (
   ID_ETUDIANT VARCHAR(20) NOT NULL  ,
   ID_MODULE VARCHAR(20) NOT NULL  ,
   NOM_SEMESTRE VARCHAR(20) NOT NULL  ,
   TD REAL(5,2) NULL  ,
   TP REAL(5,2) NULL  ,
   COTROL REAL(5,2) NULL 
   , PRIMARY KEY (ID_ETUDIANT,ID_MODULE) 
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;
 
 INSERT INTO `note` (`ID_ETUDIANT`, `ID_MODULE`, `NOM_SEMESTRE`, `TD`, `TP`, `COTROL`) 
 VALUES 
 ('ETD001', 'MOD001', 'Semestre2', '15', '18', '15.75'), 
 ('ETD002', 'MOD001', 'Semestre2', '15', '15', '14.50'), 
 ('ETD003', 'MOD001', 'Semestre2', '12.50', '15', '15.75');

 

# -----------------------------------------------------------------------------
#       TABLE : EMPLOI
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EMPLOI
 (
   ID_EMPLOI VARCHAR(32) NOT NULL  ,
   ID_SPECIALITE VARCHAR(20) NOT NULL  ,
   ID_GROUPE VARCHAR(20) NOT NULL  ,
   ID_ENSEIGNANT VARCHAR(20) NOT NULL  ,
   ID_SECTION VARCHAR(20)  NULL  ,
   ID_MODULE VARCHAR(20) NOT NULL  ,
   NOM_SALLE VARCHAR(20) NOT NULL  ,
   JOUR VARCHAR(32) NULL  ,
   HEUR_DEBUT TIME NULL  ,
   HEUR_FIN TIME NULL  
   , PRIMARY KEY (ID_EMPLOI)  
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;

 
INSERT INTO `emploi` 
(`ID_EMPLOI`,`ID_SPECIALITE`, `ID_GROUPE`, `ID_ENSEIGNANT`, `ID_SECTION`, `ID_MODULE`, `NOM_SALLE`, `JOUR`, `HEUR_DEBUT`, `HEUR_FIN`)
VALUES 
('EMP001','SPE3I', 'GRP3IG2', 'ENS001', NULL, 'MOD001', 'Salle01', 'Dimanche', '11:00:00', '12:30:00'), 
('EMP002','SPE3I', 'GRP3IG2', 'ENS002', NULL, 'MOD005', 'Salle04', 'Mardi', '11:00:00', '12:30:00');

# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE USER 
  ADD FOREIGN KEY FK_USER_TYPE_USER (ID_TYPE_USER)
      REFERENCES TYPE_USER (ID_TYPE_USER) ;


ALTER TABLE FLIERES 
  ADD FOREIGN KEY FK_FLIERES_DEPARTEMENT (ID__DEPARTEMENT)
      REFERENCES DEPARTEMENT (ID__DEPARTEMENT) ;


ALTER TABLE ETUDIANT 
  ADD FOREIGN KEY FK_ETUDIANT_SPECIALITE (ID_SPECIALITE)
      REFERENCES SPECIALITE (ID_SPECIALITE);
	  
ALTER TABLE ETUDIANT 
  ADD FOREIGN KEY FK_ETUDIANT_GROUPE (ID_GROUPE)
      REFERENCES GROUPE (ID_GROUPE) ;


ALTER TABLE ETUDIANT 
  ADD FOREIGN KEY FK_ETUDIANT_USER (ID_USER)
      REFERENCES USER (ID_USER) ;


ALTER TABLE SECTION 
  ADD FOREIGN KEY FK_SECTION_GROUPE (ID_GROUPE)
      REFERENCES GROUPE (ID_GROUPE) ;


ALTER TABLE SPECIALITE 
  ADD FOREIGN KEY FK_SPECIALITE_FLIERES (ID_FILIERE)
      REFERENCES FLIERES (ID_FILIERE) ;	  
	  

ALTER TABLE MODULE 
  ADD FOREIGN KEY FK_MODULE_UNITE_ENSEIGNER (ID_UNITE_ENSEIGNER)
      REFERENCES UNITE_ENSEIGNER (ID_UNITE_ENSEIGNER) ;

ALTER TABLE MODULE 
  ADD FOREIGN KEY FK_MODULE_TYPE_MODULE (ID_TYPE_MODULE)
      REFERENCES TYPE_MODULE (ID_TYPE_MODULE) ;

ALTER TABLE UNITE_ENSEIGNER 
  ADD FOREIGN KEY FK_UNITE_ENSEIGNER_TYPE_ENITE (ID_TYPE_ENITE)
      REFERENCES TYPE_ENITE (ID_TYPE_ENITE) ;


ALTER TABLE ENSEIGNANT 
  ADD FOREIGN KEY FK_ENSEIGNANT_USER (ID_USER)
      REFERENCES USER (ID_USER) ;

	  

ALTER TABLE ENSIGNE 
  ADD FOREIGN KEY FK_ENSIGNE_ENSEIGNANT (ID_ENSEIGNANT)
      REFERENCES ENSEIGNANT (ID_ENSEIGNANT) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE ENSIGNE 
  ADD FOREIGN KEY FK_ENSIGNE_GROUPE (ID_GROUPE)
      REFERENCES GROUPE (ID_GROUPE) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE ENSIGNE 
  ADD FOREIGN KEY FK_ENSIGNE_MODULE (ID_MODULE)
      REFERENCES MODULE (ID_MODULE) ON DELETE CASCADE ON UPDATE CASCADE;



ALTER TABLE NOTE 
  ADD FOREIGN KEY FK_NOTE_ETUDIANT (ID_ETUDIANT)
      REFERENCES ETUDIANT (ID_ETUDIANT) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE NOTE 
  ADD FOREIGN KEY FK_NOTE_MODULE (ID_MODULE)
      REFERENCES MODULE (ID_MODULE) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE NOTE 
  ADD FOREIGN KEY FK_NOTE_SEMESTRE (NOM_SEMESTRE)
      REFERENCES SEMESTRE (NOM_SEMESTRE) ON DELETE CASCADE ON UPDATE CASCADE;
	  
	  
	  
ALTER TABLE EMPLOI 
  ADD FOREIGN KEY FK_EMPLOI_SPECIALITE (ID_SPECIALITE)
      REFERENCES SPECIALITE (ID_SPECIALITE) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE EMPLOI 
  ADD FOREIGN KEY FK_EMPLOI_GROUPE (ID_GROUPE)
      REFERENCES GROUPE (ID_GROUPE) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE EMPLOI 
  ADD FOREIGN KEY FK_EMPLOI_ENSEIGNANT (ID_ENSEIGNANT)
      REFERENCES ENSEIGNANT (ID_ENSEIGNANT) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE EMPLOI 
  ADD FOREIGN KEY FK_EMPLOI_SECTION (ID_SECTION)
      REFERENCES SECTION (ID_SECTION) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE EMPLOI 
  ADD FOREIGN KEY FK_EMPLOI_MODULE (ID_MODULE)
      REFERENCES MODULE (ID_MODULE) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE EMPLOI 
  ADD FOREIGN KEY FK_EMPLOI_SALLE (NOM_SALLE)
      REFERENCES SALLE (NOM_SALLE) ON DELETE CASCADE ON UPDATE CASCADE;
	  
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LOGIN`
(IN `username` VARCHAR(50), IN `password` VARCHAR(50), IN `type_user` VARCHAR(50)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT * FROM user INNER JOIN type_user ON user.ID_TYPE_USER=type_user.ID_TYPE_USER 
WHERE user.NOM_USER=`username` AND user.PASSWORD=`password` AND user.ID_TYPE_USER=`type_user` ; 

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_INFORMATION_ETUDIANT`
(IN `id_etudiant` VARCHAR(20)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT NOM_ETUDIANT AS 'Nom ', PRENOM_ETUDIANT AS 'Prenom', NOM_GROUPE AS 'Groupe', NIVEAU AS 'Niveau', 
NOM_SPECIALITE AS 'Specialite' FROM etudiant INNER JOIN groupe ON etudiant.ID_GROUPE=groupe.ID_GROUPE 
INNER JOIN specialite ON etudiant.ID_SPECIALITE=specialite.ID_SPECIALITE 
WHERE etudiant.ID_ETUDIANT=`id_etudiant` ; 

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LISTE_GROUPE`
(IN `nom_groupe` VARCHAR(50), IN `niveau` INT(20), IN `nom_spesialite` VARCHAR(50)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT NOM_ETUDIANT AS 'Nom', PRENOM_ETUDIANT AS 'Prenom', NOM_GROUPE AS 'Groupe' FROM etudiant 
INNER JOIN groupe ON groupe.ID_GROUPE=etudiant.ID_GROUPE 
INNER JOIN specialite ON specialite.ID_SPECIALITE=etudiant.ID_SPECIALITE 
WHERE groupe.NOM_GROUPE=`nom_groupe` AND specialite.NIVEAU=`niveau` AND specialite.NOM_SPECIALITE=`nom_spesialite` ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_EMPLOI_ETUDIANT`
(IN `nom_groupe` VARCHAR(50), IN `niveau` INT(20), IN `nom_spesialite` VARCHAR(50)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT JOUR AS 'Jour', HEUR_DEBUT AS 'Heur debut', HEUR_FIN AS 'Heur fin', NOM_GROUPE AS 'Groupe', 
NOM_MODULE AS 'Module', ID_TYPE_MODULE AS 'Type', NOM_ENSEIGNANT AS 'Nom enseignant', NOM_SALLE AS 'Salle' FROM emploi 
INNER JOIN groupe ON groupe.ID_GROUPE=emploi.ID_GROUPE 
INNER JOIN module ON module.ID_MODULE=emploi.ID_MODULE 
INNER JOIN enseignant ON enseignant.ID_ENSEIGNANT=emploi.ID_ENSEIGNANT  
INNER JOIN specialite ON specialite.ID_SPECIALITE=emploi.ID_SPECIALITE
WHERE groupe.NOM_GROUPE=`nom_groupe` AND specialite.NIVEAU=`niveau` AND specialite.NOM_SPECIALITE=`nom_spesialite` ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_EMPLOI_ENSEIGNANT`
(IN `id_enseignant` VARCHAR(20)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT JOUR AS 'Jour', HEUR_DEBUT AS 'Heur debut', HEUR_FIN AS 'Heur fin', NOM_GROUPE AS 'Groupe', 
NIVEAU AS 'Niveau', NOM_SPECIALITE AS 'Specialite', NOM_MODULE AS 'Module', NOM_SALLE AS 'Salle' FROM emploi 
INNER JOIN groupe ON groupe.ID_GROUPE=emploi.ID_GROUPE 
INNER JOIN module ON module.ID_MODULE=emploi.ID_MODULE 
INNER JOIN specialite ON specialite.ID_SPECIALITE=emploi.ID_SPECIALITE 
WHERE emploi.ID_ENSEIGNANT=`id_enseignant` ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_INFORMATION_ENSEIGNANT`
(IN `id_enseignant` VARCHAR(20)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT NOM_ENSEIGNANT AS 'Nom', PRENOM_ENSEIGNANT AS 'Prenom', ADRESS_ENSEIGNANT AS 'Adress', 
EMAIL_ENSEIGNANT AS 'Email', GRADE_ENSEIGNANT AS 'Grade' FROM enseignant 
WHERE enseignant.ID_ENSEIGNANT=`id_enseignant` ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_NOTE`
(IN `id_etudiant` VARCHAR(20)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT NOM_ETUDIANT AS 'Nom ', PRENOM_ETUDIANT AS 'Prenom', NOM_GROUPE AS 'Groupe', 
NIVEAU AS 'Niveau', NOM_SPECIALITE AS 'Specialite', NOM_SEMESTRE AS 'Semestre', 
NOM_MODULE AS 'Module', TD, TP, COTROL AS 'Cours' FROM note 
INNER JOIN etudiant ON etudiant.ID_ETUDIANT=note.ID_ETUDIANT 
INNER JOIN specialite ON specialite.ID_SPECIALITE=etudiant.ID_SPECIALITE 
INNER JOIN groupe ON groupe.ID_GROUPE=etudiant.ID_GROUPE 
INNER JOIN module ON module.ID_MODULE=note.ID_MODULE 
WHERE etudiant.ID_ETUDIANT=`id_etudiant` ; 

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_EMPLOI`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT ID_EMPLOI AS 'ID Emploi', ID_SPECIALITE AS 'ID Specialite', ID_GROUPE AS 'ID Groupe', 
       ID_ENSEIGNANT AS 'ID Enseignant', ID_MODULE AS 'ID Module', NOM_SALLE AS 'Nom Salle', 
       JOUR AS 'Jour', HEUR_DEBUT AS 'Heur Debut', HEUR_FIN AS 'Heur Fin'
FROM emploi ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_ETUDIANT`
(IN `niveau` INT(20), IN `nom_spesialite` VARCHAR(50)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT ID_ETUDIANT AS 'ID Etudiant', NOM_ETUDIANT AS 'Nom etudaint', PRENOM_ETUDIANT AS 'Prenom etudiant', 
DATA_DE_NAISSANCE AS 'Date de naissance', LIEN_DE_NAISSANCE AS 'Lien de naissance', ADRESS_ETUDIANT AS 'Adress etudiant', 
EMAIL_ETUDIANT AS 'Email etudiant', TELEPHONE_ETUDIANT AS 'Telephone etudiant', NIVEAU AS 'Niveau', 
NOM_SPECIALITE AS 'Specialite', NOM_GROUPE AS 'Nom groupe' FROM etudiant 
INNER JOIN groupe ON groupe.ID_GROUPE=etudiant.ID_GROUPE
INNER JOIN specialite ON specialite.ID_SPECIALITE=etudiant.ID_SPECIALITE 
WHERE specialite.NIVEAU=`niveau` AND specialite.NOM_SPECIALITE=`nom_spesialite` ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_ETUDIANT`
(IN `id_etudiant` VARCHAR(20), IN `id_specialite` VARCHAR(20), IN `id_groupe` VARCHAR(20), 
 IN `nom_etudiant` VARCHAR(50), IN `prenom_etudiant` VARCHAR(50), IN `data_de_naissance` DATE,
 IN `lien_de_naissance` VARCHAR(60),IN `adress_etudiant` VARCHAR(60), IN `email_etudiant` VARCHAR(60), 
 IN `telephone_etudiant` INT(20), IN `annee_etud` DATE) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
INSERT INTO etudiant (ID_ETUDIANT, ID_SPECIALITE, ID_USER, ID_GROUPE, NOM_ETUDIANT, PRENOM_ETUDIANT, 
DATA_DE_NAISSANCE, LIEN_DE_NAISSANCE, ADRESS_ETUDIANT, EMAIL_ETUDIANT, TELEPHONE_ETUDIANT, ANNEE_ETUD, PASSWORD) 
VALUES (id_etudiant, id_specialite, NULL, id_groupe, nom_etudiant, prenom_etudiant, data_de_naissance, 
lien_de_naissance, adress_etudiant, email_etudiant, telephone_etudiant, annee_etud, NULL) ; 

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CHERCHE_ETUDIANT`(IN `id_etud` VARCHAR(60)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT ID_ETUDIANT AS 'ID Etudiant', NOM_ETUDIANT AS 'Nom etudaint', PRENOM_ETUDIANT AS 'Prenom etudiant', DATA_DE_NAISSANCE AS 'Date de naissance', 
LIEN_DE_NAISSANCE AS 'Lien de naissance', ADRESS_ETUDIANT AS 'Adress etudiant', EMAIL_ETUDIANT AS 'Email etudiant', 
TELEPHONE_ETUDIANT AS 'Telephone etudiant' FROM etudiant 
WHERE 
(etudiant.ID_ETUDIANT + etudiant.NOM_ETUDIANT + etudiant.PRENOM_ETUDIANT + etudiant.DATA_DE_NAISSANCE + etudiant.LIEN_DE_NAISSANCE + 
etudiant.ADRESS_ETUDIANT + etudiant.EMAIL_ETUDIANT + etudiant.TELEPHONE_ETUDIANT Like id_etud ) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_ETUDIANT`
(IN `id_etudiant` VARCHAR(20), IN `id_specialite` VARCHAR(20), IN `id_groupe` VARCHAR(20), IN `nom_etudiant` VARCHAR(50), IN `prenom_etudiant` VARCHAR(50), 
 IN `data_de_naissance` DATE, IN `lien_de_naissance` VARCHAR(60), IN `adress_etudiant` VARCHAR(60), IN `email_etudiant` VARCHAR(60), 
 IN `telephone_etudiant` INT(20), IN `annee_etud` DATE) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
UPDATE etudiant
INNER JOIN specialite ON specialite.ID_SPECIALITE=etudiant.ID_SPECIALITE
INNER JOIN groupe ON groupe.ID_GROUPE=etudiant.ID_GROUPE
SET specialite.ID_SPECIALITE=id_specialite,
groupe.ID_GROUPE=id_groupe, etudiant.NOM_ETUDIANT=nom_etudiant, etudiant.PRENOM_ETUDIANT=prenom_etudiant, etudiant.DATA_DE_NAISSANCE=data_de_naissance, 
etudiant.LIEN_DE_NAISSANCE=lien_de_naissance, etudiant.ADRESS_ETUDIANT=adress_etudiant, etudiant.EMAIL_ETUDIANT=email_etudiant, 
etudiant.TELEPHONE_ETUDIANT=telephone_etudiant, etudiant.ANNEE_ETUD=annee_etud
WHERE etudiant.ID_ETUDIANT=id_etudiant ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_ID_GROUPE`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT ID_GROUPE FROM groupe ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_ID_SPECIALITE`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT ID_SPECIALITE FROM specialite ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_VERIFY_ETUDIANT`(IN `id` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT * FROM etudiant
WHERE etudiant.ID_ETUDIANT=id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DELETE_ETUDIANT`(IN `id` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER DELETE FROM etudiant
WHERE etudiant.ID_ETUDIANT=id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_ID_UNITE_NESEIGNER`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT ID_UNITE_ENSEIGNER FROM unite_enseigner ; 

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_ID_TYPE_MODULE`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT ID_TYPE_MODULE FROM type_module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_MODULE`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT ID_MODULE AS 'ID Module', 
ID_UNITE_ENSEIGNER AS 'ID Unite Enseigner', ID_TYPE_MODULE AS 'ID Type Module', 
NOM_MODULE AS 'Nom Module', COEFFICIENT_MODULE AS 'Coefficient' FROM module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_MODULE`
(IN `id_module` VARCHAR(20), IN `id_unite_enseigner` VARCHAR(32), 
 IN `id_type_module` VARCHAR(20), IN `nom_module` VARCHAR(50), 
 IN `coefficient` INT(2)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
INSERT INTO module (ID_MODULE, ID_UNITE_ENSEIGNER, ID_TYPE_MODULE, NOM_MODULE, COEFFICIENT_MODULE) 
VALUES (id_module, id_unite_enseigner, id_type_module, nom_module, coefficient) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_MODULE`
(IN `id_module` VARCHAR(20), IN `id_unite_enseigner` VARCHAR(32), 
 IN `id_type_module` VARCHAR(20), IN `nom_module` VARCHAR(50), 
 IN `coefficient` INT(2)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER UPDATE module 
INNER JOIN unite_enseigner ON unite_enseigner.ID_UNITE_ENSEIGNER=module.ID_UNITE_ENSEIGNER 
INNER JOIN type_module ON type_module.ID_TYPE_MODULE=module.ID_TYPE_MODULE
SET module.ID_UNITE_ENSEIGNER=id_unite_enseigner, module.ID_TYPE_MODULE=id_type_module,  
module.NOM_MODULE=nom_module, module.COEFFICIENT_MODULE=coefficient
WHERE module.ID_MODULE=id_module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_VERIFY_MODULE`(IN `id` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT * FROM module
WHERE module.ID_MODULE=id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_NOTE`
(IN `id_etudiant` VARCHAR(20), IN `id_module` VARCHAR(20), 
 IN `nom_semestre` VARCHAR(20), IN `td_module` DOUBLE(5,2), 
 IN `tp_module` DOUBLE(5,2), IN `cours_module` DOUBLE(5,2)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER INSERT INTO note 
(ID_ETUDIANT, ID_MODULE, NOM_SEMESTRE, TD, TP, COTROL) VALUES 
(id_etudiant, id_module, nom_semestre, td_module, tp_module, cours_module) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_NOTE_TD_NULL`
(IN `id_etudiant` VARCHAR(20), IN `id_module` VARCHAR(20), 
 IN `nom_semestre` VARCHAR(20), IN `tp_module` DOUBLE(5,2), IN `cours_module` DOUBLE(5,2)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER INSERT INTO note 
(ID_ETUDIANT, ID_MODULE, NOM_SEMESTRE, TD, TP, COTROL) VALUES 
(id_etudiant, id_module, nom_semestre, null, tp_module, cours_module) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_NOTE_TP_NULL`
(IN `id_etudiant` VARCHAR(20), IN `id_module` VARCHAR(20), 
 IN `nom_semestre` VARCHAR(20), IN `td_module` DOUBLE(5,2), IN `cours_module` DOUBLE(5,2)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER INSERT INTO note 
(ID_ETUDIANT, ID_MODULE, NOM_SEMESTRE, TD, TP, COTROL) VALUES 
(id_etudiant, id_module, nom_semestre, td_module, null, cours_module) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_NOTE_TD_ET_TP_NULL`
(IN `id_etudiant` VARCHAR(20), IN `id_module` VARCHAR(20), 
 IN `nom_semestre` VARCHAR(20), IN `cours_module` DOUBLE(5,2)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER INSERT INTO note 
(ID_ETUDIANT, ID_MODULE, NOM_SEMESTRE, TD, TP, COTROL) VALUES 
(id_etudiant, id_module, nom_semestre, null, null, cours_module) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_IDETUDIANT`(IN `nom_etud` VARCHAR(50), 
IN `prenom_etud` VARCHAR(50), IN `niveau` INT(20), IN `nom_specialite` VARCHAR(50), 
IN `groupe_etud` VARCHAR(50)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT ID_ETUDIANT FROM etudiant
INNER JOIN specialite ON specialite.ID_SPECIALITE=etudiant.ID_SPECIALITE
INNER JOIN groupe ON groupe.ID_GROUPE=etudiant.ID_GROUPE 
WHERE
etudiant.NOM_ETUDIANT=nom_etud AND etudiant.PRENOM_ETUDIANT=prenom_etud AND
specialite.NIVEAU=niveau AND specialite.NOM_SPECIALITE=nom_specialite AND
groupe.NOM_GROUPE=groupe_etud ;


CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_IDMODULE`(IN `nom_module` VARCHAR(50)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT ID_MODULE FROM module
INNER JOIN type_module on type_module.ID_TYPE_MODULE=module.ID_TYPE_MODULE
WHERE module.ID_TYPE_MODULE='Cours' AND module.NOM_MODULE=nom_module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_ETUDIANT_ADMIN`(IN `niveau` INT(20), 
IN `nom_spesialite` VARCHAR(50), IN `groupe` VARCHAR(50)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT ID_ETUDIANT, NOM_ETUDIANT, PRENOM_ETUDIANT,  
DATA_DE_NAISSANCE, LIEN_DE_NAISSANCE, ADRESS_ETUDIANT, 
EMAIL_ETUDIANT, TELEPHONE_ETUDIANT, ANNEE_ETUD, NIVEAU, 
NOM_SPECIALITE, NOM_GROUPE FROM etudiant 
INNER JOIN groupe ON groupe.ID_GROUPE=etudiant.ID_GROUPE
INNER JOIN specialite ON specialite.ID_SPECIALITE=etudiant.ID_SPECIALITE 
WHERE specialite.NIVEAU=niveau AND specialite.NOM_SPECIALITE=nom_spesialite AND
groupe.NOM_GROUPE=groupe ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_NOTE_ADMIN`
(IN `niveau` INT(20), IN `nom_spesialite` VARCHAR(50), IN `groupe` VARCHAR(50)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT  NOM_ETUDIANT AS 'Nom etudaint', PRENOM_ETUDIANT AS 'Prenom etudiant', NIVEAU AS 'Niveau', NOM_SPECIALITE AS 'Specialite', 
NOM_GROUPE AS 'Nom groupe', NOM_SEMESTRE AS 'Semestre', NOM_MODULE AS 'Module', TD, TP, COTROL AS 'Cours' FROM note
INNER JOIN etudiant ON etudiant.ID_ETUDIANT=note.ID_ETUDIANT 
INNER JOIN specialite ON specialite.ID_SPECIALITE=etudiant.ID_SPECIALITE 
INNER JOIN groupe ON groupe.ID_GROUPE=etudiant.ID_GROUPE
INNER JOIN module ON module.ID_MODULE=note.ID_MODULE 
WHERE
note.ID_ETUDIANT=etudiant.ID_ETUDIANT AND
note.ID_MODULE=module.ID_MODULE AND
specialite.NIVEAU=niveau AND
specialite.NOM_SPECIALITE=nom_spesialite AND groupe.NOM_GROUPE=groupe ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_NIVEAU`() NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT NIVEAU FROM specialite WHERE specialite.NOM_SPECIALITE!='Math' 
AND specialite.NOM_SPECIALITE!='Mastre';

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_SPECIALITE`(IN `niveau` INT(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT NOM_SPECIALITE FROM specialite
WHERE specialite.NIVEAU=niveau ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_GROUPE`() NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT * FROM groupe ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_NOTE`
(IN `id_etudiant` VARCHAR(20), IN `id_module` VARCHAR(20), IN `nom_semestre` VARCHAR(20), IN `td_module` DOUBLE(5,2), 
 IN `tp_module` DOUBLE(5,2), IN `cours_module` DOUBLE(5,2)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
UPDATE note
INNER JOIN etudiant ON etudiant.ID_ETUDIANT=note.ID_ETUDIANT
INNER JOIN module ON module.ID_MODULE=note.ID_MODULE
INNER JOIN semestre ON semestre.NOM_SEMESTRE=note.NOM_SEMESTRE
SET semestre.NOM_SEMESTRE=nom_semestre, note.TD=td_module, note.TP=tp_module, note.COTROL=cours_module
WHERE etudiant.ID_ETUDIANT=id_etudiant AND module.ID_MODULE=id_module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_NOTE_TD_NULL`
(IN `id_etudiant` VARCHAR(20), IN `id_module` VARCHAR(20), IN `nom_semestre` VARCHAR(20), 
 IN `tp_module` DOUBLE(5,2), IN `cours_module` DOUBLE(5,2)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
UPDATE note
INNER JOIN etudiant ON etudiant.ID_ETUDIANT=note.ID_ETUDIANT
INNER JOIN module ON module.ID_MODULE=note.ID_MODULE
INNER JOIN semestre ON semestre.NOM_SEMESTRE=note.NOM_SEMESTRE
SET semestre.NOM_SEMESTRE=nom_semestre, note.TD=null, note.TP=tp_module, note.COTROL=cours_module
WHERE etudiant.ID_ETUDIANT=id_etudiant AND module.ID_MODULE=id_module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_NOTE_TP_NULL`
(IN `id_etudiant` VARCHAR(20), IN `id_module` VARCHAR(20), IN `nom_semestre` VARCHAR(20), IN `td_module` DOUBLE(5,2), IN `cours_module` DOUBLE(5,2)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER UPDATE note
INNER JOIN etudiant ON etudiant.ID_ETUDIANT=note.ID_ETUDIANT
INNER JOIN module ON module.ID_MODULE=note.ID_MODULE
INNER JOIN semestre ON semestre.NOM_SEMESTRE=note.NOM_SEMESTRE
SET semestre.NOM_SEMESTRE=nom_semestre, note.TD=td_module, note.TP=null, note.COTROL=cours_module
WHERE etudiant.ID_ETUDIANT=id_etudiant AND module.ID_MODULE=id_module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_NOTE_TD_ET_TP_NULL`
(IN `id_etudiant` VARCHAR(20), IN `id_module` VARCHAR(20), IN `nom_semestre` VARCHAR(20), IN `cours_module` DOUBLE(5,2)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER UPDATE note
INNER JOIN etudiant ON etudiant.ID_ETUDIANT=note.ID_ETUDIANT
INNER JOIN module ON module.ID_MODULE=note.ID_MODULE
INNER JOIN semestre ON semestre.NOM_SEMESTRE=note.NOM_SEMESTRE
SET semestre.NOM_SEMESTRE=nom_semestre, note.TD=null, note.TP=null, note.COTROL=cours_module
WHERE etudiant.ID_ETUDIANT=id_etudiant AND module.ID_MODULE=id_module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DELETE_MODULE`
(IN `id` VARCHAR(20)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER DELETE FROM module
WHERE module.ID_MODULE=id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DELETE_NOTE`
(IN `id_etud` VARCHAR(20), IN `id_module` VARCHAR(20)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
DELETE FROM note
WHERE 
note.ID_ETUDIANT=id_etud
AND
note.ID_MODULE=id_module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_ENSEIGNANT`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT 
ID_ENSEIGNANT, NOM_ENSEIGNANT, PRENOM_ENSEIGNANT,	ADRESS_ENSEIGNANT, 
EMAIL_ENSEIGNANT, TELEPHONE_ENSEIGNANT, GRADE_ENSEIGNANT FROM enseignant ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_VERIFY_ENSEIGNANT`(IN `id` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT * FROM enseignant
WHERE enseignant.ID_ENSEIGNANT=id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_ENSEIGNANT`(IN `id_ens` 
VARCHAR(20), IN `nom_ens` VARCHAR(50), IN `prenom_ens` VARCHAR(50), IN `date_naissance` DATE, IN `lien_naissance` VARCHAR(60),
 IN `adress_ens` VARCHAR(60), IN `email_ens` VARCHAR(60), IN `tel_ens` INT(20), IN `rgade_ens` VARCHAR(30))
 NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER INSERT INTO enseignant 
 (ID_ENSEIGNANT, ID_USER, NOM_ENSEIGNANT, PRENOM_ENSEIGNANT, DATA_DE_NAISSANCE, LIEN_DE_NAISSANCE, ADRESS_ENSEIGNANT,
 EMAIL_ENSEIGNANT, TELEPHONE_ENSEIGNANT, GRADE_ENSEIGNANT, PASSWORD) 
VALUES (id_ens, NULL, nom_ens, prenom_ens, date_naissance, lien_naissance, adress_ens, email_ens, tel_ens, rgade_ens, NULL) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_ENSEIGNANT`
(IN `id_ens` VARCHAR(20), IN `nom_ens` VARCHAR(50), IN `prenom_ens` VARCHAR(50), 
 IN `date_naissance` DATE, IN `lien_naissance` VARCHAR(60), IN `adress_ens` VARCHAR(60), 
 IN `email_ens` VARCHAR(60), IN `tel_ens` INT(20), IN `rgade_ens` VARCHAR(30)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER
UPDATE enseignant
SET enseignant.NOM_ENSEIGNANT=nom_ens, enseignant.PRENOM_ENSEIGNANT=prenom_ens,
enseignant.DATA_DE_NAISSANCE=date_naissance,
enseignant.LIEN_DE_NAISSANCE=lien_naissance,
enseignant.ADRESS_ENSEIGNANT=adress_ens,
enseignant.EMAIL_ENSEIGNANT=email_ens,
enseignant.TELEPHONE_ENSEIGNANT=tel_ens,
enseignant.GRADE_ENSEIGNANT=rgade_ens
WHERE enseignant.ID_ENSEIGNANT=id_ens ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DELETE_ENSEIGNANT`
(IN `id_ens` VARCHAR(20)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
DELETE FROM enseignant
WHERE enseignant.ID_ENSEIGNANT = id_ens ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_TYPE_USER`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT * FROM type_user ;


CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_USER_PASSWORD`
(IN `id` INT(20), IN `nom_user` VARCHAR(50), IN `type_user`
VARCHAR(50), IN `password` VARCHAR(50)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER UPDATE user
INNER JOIN type_user on 
type_user.ID_TYPE_USER = user.ID_TYPE_USER
SET user.NOM_USER = nom_user ,
user.ID_TYPE_USER = type_user ,
user.PASSWORD = password
WHERE user.ID_USER = id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_PASSWORD`(IN `type_user`
VARCHAR(50)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT PASSWORD FROM user
WHERE user.ID_TYPE_USER = type_user ;


CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_ID_USER`(IN `type_user` 
VARCHAR(50)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT ID_USER FROM user
WHERE user.ID_TYPE_USER = type_user ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_SP_GET_NOTE_CRYSTAL_REPORT`
(IN `specialite` VARCHAR(50), IN `niveau` INT(20), IN `nom_grp` VARCHAR(20),
IN `nom_model` VARCHAR(50)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT  NOM_ETUDIANT AS 'Nom etudaint', PRENOM_ETUDIANT AS 'Prenom etudiant',
NIVEAU AS 'Niveau', NOM_SPECIALITE AS 'Specialite', 
NOM_GROUPE AS 'Nom groupe', NOM_SEMESTRE AS 'Semestre', NOM_MODULE AS 'Module',
TD, TP, COTROL AS 'Cours',NOM_ENSEIGNANT AS 'Nom Enseignant', PRENOM_ENSEIGNANT AS 'Prenom Enseignant' FROM etudiant
INNER JOIN note ON etudiant.ID_ETUDIANT=note.ID_ETUDIANT 
INNER JOIN module ON module.ID_MODULE=note.ID_MODULE 
INNER JOIN groupe ON groupe.ID_GROUPE=etudiant.ID_GROUPE
INNER JOIN ensigne ON ensigne.ID_GROUPE = groupe.ID_GROUPE
INNER JOIN enseignant ON enseignant.ID_ENSEIGNANT = ensigne.ID_ENSEIGNANT
INNER JOIN specialite ON specialite.ID_SPECIALITE=etudiant.ID_SPECIALITE
WHERE 
specialite.NOM_SPECIALITE = specialite AND
specialite.NIVEAU = niveau AND
groupe.NOM_GROUPE = nom_grp AND
module.NOM_MODULE = nom_model ;


CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_NOM_MODULE`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT * FROM module ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_SALLE`() 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT * FROM salle ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DELETE_EMPLOI`(IN `id_emp` VARCHAR(32)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER DELETE FROM emploi
WHERE emploi.ID_EMPLOI=id_emp ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_EMPLOI`
(IN `id_emp` VARCHAR(32), IN `id_specialite` VARCHAR(20), IN `id_groupe` VARCHAR(20), 
 IN `id_ens` VARCHAR(20), IN `id_mod` VARCHAR(20), IN `salle` VARCHAR(20), IN `jour` VARCHAR(32), 
 IN `heur_debut` TIME(6), IN `heur_fin` TIME(6)) 
 NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER INSERT INTO emploi 
(ID_EMPLOI, ID_SPECIALITE, ID_GROUPE, ID_ENSEIGNANT, ID_SECTION, ID_MODULE, NOM_SALLE, JOUR, HEUR_DEBUT, HEUR_FIN)
VALUES (id_emp, id_specialite, id_groupe, id_ens, null, id_mod, salle, jour, heur_debut, heur_fin) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_EMPLOI`
(IN `id_emp` VARCHAR(32), IN `id_specialite` VARCHAR(20), IN `id_groupe` VARCHAR(20), 
 IN `id_ens` VARCHAR(20), IN `id_mod` VARCHAR(20), IN `salle` VARCHAR(20), IN `jour` VARCHAR(32), 
 IN `heur_debut` TIME(6), IN `heur_fin` TIME(6)) NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
UPDATE emploi
INNER JOIN specialite ON specialite.ID_SPECIALITE=emploi.ID_SPECIALITE
INNER JOIN groupe ON groupe.ID_GROUPE=emploi.ID_GROUPE
INNER JOIN enseignant ON enseignant.ID_ENSEIGNANT=emploi.ID_ENSEIGNANT
INNER JOIN module ON module.ID_MODULE=emploi.ID_MODULE
INNER JOIN salle ON salle.NOM_SALLE=emploi.NOM_SALLE
SET emploi.ID_SPECIALITE=id_specialite,
emploi.ID_GROUPE=id_groupe,
emploi.ID_ENSEIGNANT=id_ens, emploi.ID_SECTION=null,
emploi.ID_MODULE=id_mod, emploi.NOM_SALLE=salle,
emploi.JOUR=jour, emploi.HEUR_DEBUT=heur_debut, emploi.HEUR_FIN=heur_fin
WHERE emploi.ID_EMPLOI=id_emp ;


CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_GROUPE`(IN `id` VARCHAR(20), IN `nom` VARCHAR(50)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER INSERT INTO 
groupe (ID_GROUPE, NOM_GROUPE) VALUES (id, nom) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_GROUPE`(IN `id` VARCHAR(20), IN `nom` VARCHAR(50)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER UPDATE groupe
SET groupe.NOM_GROUPE=nom WHERE groupe.ID_GROUPE=id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ADD_SALLE`(IN `nom` VARCHAR(20), IN `capacite` INT(3)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER INSERT INTO 
salle(NOM_SALLE, CAPACITE) VALUES (nom, capacite) ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_EDIT_SALLE`(IN `nom` VARCHAR(20), IN `capacite` INT(3)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER UPDATE salle
SET salle.CAPACITE=capacite WHERE salle.NOM_SALLE=nom ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DELETE_SALLE`(IN `nom` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER DELETE FROM salle
WHERE salle.NOM_SALLE=nom ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DELETE_GROUPE`(IN `id` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER DELETE FROM groupe
WHERE groupe.ID_GROUPE=id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_VERIFY_GROUPE`(IN `id` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT * FROM groupe
WHERE groupe.ID_GROUPE=id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_VERIFY_SALLE`(IN `nom` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER 
SELECT * FROM salle
WHERE salle.NOM_SALLE=nom ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_EMAIL`(IN `id` VARCHAR(20))
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT NOM_ETUDIANT, PRENOM_ETUDIANT, EMAIL_ETUDIANT FROM etudiant
WHERE etudiant.ID_ETUDIANT = id ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_print_certificat_scolarité`(IN `ID` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT ID_ETUDIANT AS 'ID' , NOM_ETUDIANT AS 'Nom ', PRENOM_ETUDIANT AS 'Prenom', 
DATA_DE_NAISSANCE AS 'Date naissance', 
LIEN_DE_NAISSANCE AS 'Lien de naissance', 
NOM_SPECIALITE AS 'Specialite' , NIVEAU AS 'Niveau' 
FROM etudiant INNER JOIN specialite ON  specialite.ID_SPECIALITE =etudiant.ID_SPECIALITE 
WHERE etudiant.ID_ETUDIANT= ID ;

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GET_NOMMODUL_EMAIL`(IN `ID` VARCHAR(20)) 
NOT DETERMINISTIC NO SQL SQL SECURITY DEFINER SELECT NOM_MODULE FROM module
WHERE module.ID_MODULE = ID ;

