CREATE TABLE [dbo].[Candidates]
(
    Candidate_ID INT PRIMARY KEY NOT NULL,
    NA_ID INT NULL,
    Candidate_Name VARCHAR(50) NULL,
    Party VARCHAR(50) NULL,
    Picture IMAGE NULL,
    NA_Name VARCHAR(50) NULL,
    FOREIGN KEY (NA_ID) REFERENCES [dbo].[NA](NA_ID)
);




