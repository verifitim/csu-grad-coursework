
-- -----------------------------------------------------
-- Table organizations
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS organizations (
  org_ID INT NOT NULL,
  org_name VARCHAR(45) NOT NULL,
  customer_since DATE NOT NULL,
  PRIMARY KEY (org_ID))
;


-- -----------------------------------------------------
-- Table cloud_services
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS cloud_services (
  service_ID INT NOT NULL,
  service_name VARCHAR(45) NOT NULL,
  compute_speed VARCHAR(10) NOT NULL,
  PRIMARY KEY (service_ID))
;


-- -----------------------------------------------------
-- Table instance
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS instance (
  organizations_org_ID INT NOT NULL,
  cloud_services_service_ID INT NOT NULL,
  total_minutes FLOAT NOT NULL,
  total_cost FLOAT NOT NULL,
  PRIMARY KEY (organizations_org_ID, cloud_services_service_ID),
  
  CONSTRAINT fk_organizations_has_cloud_services_organizations
    FOREIGN KEY (organizations_org_ID)
    REFERENCES organizations (org_ID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
    
  CONSTRAINT fk_organizations_has_cloud_services_cloud_services1
    FOREIGN KEY (cloud_services_service_ID)
    REFERENCES cloud_services (service_ID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;


-- -----------------------------------------------------
-- Table users
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS users (
  userID INT NOT NULL,
  role VARCHAR(45) NOT NULL,
  organizations_org_ID INT NOT NULL,
  PRIMARY KEY (userID),

  CONSTRAINT fk_users_organizations1
    FOREIGN KEY (organizations_org_ID)
    REFERENCES organizations (org_ID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;


-- -----------------------------------------------------
-- Table users_has_instance
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS users_has_instance (
  users_userID INT NOT NULL,
  instance_organizations_org_ID INT NOT NULL,
  instance_cloud_services_service_ID INT NOT NULL,
  last_accessed DATETIME NOT NULL,
  PRIMARY KEY (users_userID, instance_organizations_org_ID, instance_cloud_services_service_ID),

  CONSTRAINT fk_users_has_instance_users1
    FOREIGN KEY (users_userID)
    REFERENCES users (userID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,

  CONSTRAINT fk_users_has_instance_instance1
    FOREIGN KEY (instance_organizations_org_ID , instance_cloud_services_service_ID)
    REFERENCES instance (organizations_org_ID , cloud_services_service_ID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

-- Change USER_ID to EMP_ID

CREATE OR REPLACE TABLE users (
  empID VARCHAR(10) NOT NULL,
  userID INT NOT NULL,
  role VARCHAR(45) NOT NULL,
  organizations_org_ID INT NOT NULL,
  PRIMARY KEY (empID),

  CONSTRAINT fk_users_organizations1
    FOREIGN KEY (organizations_org_ID)
    REFERENCES organizations (org_ID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

--  Update users_instances table to have empID instead of userID
ALTER TABLE users_has_instance
DROP users_userID;

ALTER TABLE users_has_instance
ADD empID VARCHAR(10);

ALTER TABLE users_has_instance
ADD CONSTRAINT fk_users_has_instance_empID
    FOREIGN KEY (empID)
    REFERENCES users (empID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;

-- Check Number of Foreign Keys
SELECT *
FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS;  
