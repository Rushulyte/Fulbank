DROP DATABASE IF EXISTS MLR;

CREATE DATABASE IF NOT EXISTS MLR;
USE MLR;
# -----------------------------------------------------------------------------
#       TABLE : USER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS USER
 (
   ID_USER INTEGER NOT NULL  ,
   ID_USER_TYPE INTEGER NOT NULL  ,
   NAME VARCHAR(128) NOT NULL  ,
   AUTH_STRING VARCHAR(255) NOT NULL  ,
   EMAIL VARCHAR(128) NULL  ,
   PHONE VARCHAR(128) NULL  ,
   ADDRESS VARCHAR(128) NULL  ,
   SALT VARCHAR(255) NOT NULL  
   , PRIMARY KEY (ID_USER) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE USER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_USER_USER_TYPE
     ON USER (ID_USER_TYPE ASC);

# -----------------------------------------------------------------------------
#       TABLE : BANK_ACCOUNT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS BANK_ACCOUNT
 (
   ID_BANK_ACCOUNT INTEGER NOT NULL  ,
   ID_USER INTEGER NOT NULL  ,
   ID_CURRENCY INTEGER NOT NULL  ,
   ID_BANK_ACCOUNT_TYPE INTEGER NOT NULL  ,
   BALANCE DECIMAL(10,2) NOT NULL  ,
   RIB VARCHAR(128) NOT NULL  
   , PRIMARY KEY (ID_BANK_ACCOUNT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE BANK_ACCOUNT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_BANK_ACCOUNT_USER
     ON BANK_ACCOUNT (ID_USER ASC);

CREATE  INDEX I_FK_BANK_ACCOUNT_CURRENCY
     ON BANK_ACCOUNT (ID_CURRENCY ASC);

CREATE  INDEX I_FK_BANK_ACCOUNT_BANK_ACCOUNT_TYPE
     ON BANK_ACCOUNT (ID_BANK_ACCOUNT_TYPE ASC);

# -----------------------------------------------------------------------------
#       TABLE : USER_TYPE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS USER_TYPE
 (
   ID_USER_TYPE INTEGER NOT NULL  ,
   LABEL VARCHAR(128) NOT NULL  
   , PRIMARY KEY (ID_USER_TYPE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : BANK_ACCOUNT_TYPE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS BANK_ACCOUNT_TYPE
 (
   ID_BANK_ACCOUNT_TYPE INTEGER NOT NULL  ,
   NAME VARCHAR(128) NOT NULL  ,
   INTEREST DECIMAL(10,2) NOT NULL  ,
   CEIL DECIMAL(10,2) NOT NULL  
   , PRIMARY KEY (ID_BANK_ACCOUNT_TYPE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CURRENCY
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CURRENCY
 (
   ID_CURRENCY INTEGER NOT NULL  ,
   LABEL VARCHAR(128) NOT NULL  
   , PRIMARY KEY (ID_CURRENCY) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : INTERN_OPERATION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS INTERN_OPERATION
 (
   ID_INT_OPERATION INTEGER NOT NULL  ,
   ID_BANK_ACCOUNT INTEGER NOT NULL  ,
   ID_BANK_ACCOUNT_INT_RECEIVE INTEGER NOT NULL  ,
   AMOUNT DECIMAL(10,2) NOT NULL  ,
   CREATED_DATE DATETIME NOT NULL  
   , PRIMARY KEY (ID_INT_OPERATION) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE INTERN_OPERATION
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_INTERN_OPERATION_BANK_ACCOUNT
     ON INTERN_OPERATION (ID_BANK_ACCOUNT ASC);

CREATE  INDEX I_FK_INTERN_OPERATION_BANK_ACCOUNT1
     ON INTERN_OPERATION (ID_BANK_ACCOUNT_INT_RECEIVE ASC);

# -----------------------------------------------------------------------------
#       TABLE : EXTERN_OPERATION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EXTERN_OPERATION
 (
   ID_EXT_OPERATION INTEGER NOT NULL  ,
   ID_BANK_ACCOUNT INTEGER NOT NULL  ,
   TARGET_RIB VARCHAR(128) NOT NULL  ,
   AMOUNT DECIMAL(10,2) NOT NULL  ,
   CREATED_DATE DATETIME NOT NULL  
   , PRIMARY KEY (ID_EXT_OPERATION) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE EXTERN_OPERATION
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_EXTERN_OPERATION_BANK_ACCOUNT
     ON EXTERN_OPERATION (ID_BANK_ACCOUNT ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE USER 
  ADD FOREIGN KEY FK_USER_USER_TYPE (ID_USER_TYPE)
      REFERENCES USER_TYPE (ID_USER_TYPE) ;


ALTER TABLE BANK_ACCOUNT 
  ADD FOREIGN KEY FK_BANK_ACCOUNT_USER (ID_USER)
      REFERENCES USER (ID_USER) ;


ALTER TABLE BANK_ACCOUNT 
  ADD FOREIGN KEY FK_BANK_ACCOUNT_CURRENCY (ID_CURRENCY)
      REFERENCES CURRENCY (ID_CURRENCY) ;


ALTER TABLE BANK_ACCOUNT 
  ADD FOREIGN KEY FK_BANK_ACCOUNT_BANK_ACCOUNT_TYPE (ID_BANK_ACCOUNT_TYPE)
      REFERENCES BANK_ACCOUNT_TYPE (ID_BANK_ACCOUNT_TYPE) ;


ALTER TABLE INTERN_OPERATION 
  ADD FOREIGN KEY FK_INTERN_OPERATION_BANK_ACCOUNT (ID_BANK_ACCOUNT)
      REFERENCES BANK_ACCOUNT (ID_BANK_ACCOUNT) ;


ALTER TABLE INTERN_OPERATION 
  ADD FOREIGN KEY FK_INTERN_OPERATION_BANK_ACCOUNT1 (ID_BANK_ACCOUNT_INT_RECEIVE)
      REFERENCES BANK_ACCOUNT (ID_BANK_ACCOUNT) ;


ALTER TABLE EXTERN_OPERATION 
  ADD FOREIGN KEY FK_EXTERN_OPERATION_BANK_ACCOUNT (ID_BANK_ACCOUNT)
      REFERENCES BANK_ACCOUNT (ID_BANK_ACCOUNT) ;

