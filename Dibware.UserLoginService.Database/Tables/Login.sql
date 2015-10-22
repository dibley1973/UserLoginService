CREATE TABLE [application].[Login] (
    [Username]                      UNIQUEIDENTIFIER NOT NULL,
    [Password]                      NVARCHAR (255)   NOT NULL,
	[IsLockedOut]				    BIT             NOT NULL DEFAULT((0)),
    [CreationDate]                  DATETIME2 (3)       NULL,
	[ConfirmationToken]		        NVARCHAR(128)       NULL,
	[LastActivityDate]		        DATETIME2 (3)    NOT NULL,
	[LastLoginDate]			        DATETIME2 (3)       NULL,
	[LastLockedOutDate ]	        DATETIME2 (3)       NULL,
	[LastPasswordSuccessDate]       DATETIME2 (3)       NULL,
	[LastPasswordFailureDate]       DATETIME2 (3)       NULL,
	[LastPasswordChangedDate]       DATETIME2 (3)    NOT NULL,
	[PasswordVerificationTokenExpirationDate] DATETIME2 (3)    NULL,
	[PasswordVerificationToken]     NVARCHAR(128),
	[PasswordFailuresSinceLastSuccess]  INT NOT NULL DEFAULT((0)),
	[SuccessfulLogins]			    INT		NOT NULL DEFAULT((0)),
	[UnsuccessfulLogins]		    INT		NOT NULL DEFAULT((0)),
    [Comment]                       VARCHAR(MAX) NULL
    CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED ([Username] ASC)
);

