UPDATE SCHEMES SET FROM_DATE = T.MINNAVDATE, TO_DATE = T.MAXNAVDATE
FROM (select MIN(NAVDATE) AS MINNAVDATE, MAX(NAVDATE) AS MAXNAVDATE, SCHEMECODE from NAVRECORDS GROUP BY 3) AS  T
WHERE SCHEMES.SCHEMECODE = T.SCHEMECODE