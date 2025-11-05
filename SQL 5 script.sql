--1.
SELECT RPAD(cus_fname || ' ' || cus_lname, 20) AS "Full Name"
FROM avia_customer
WHERE cus_code IN (SELECT cus_code FROM charter);


--2.
SELECT 
    RPAD(AC.CUS_FNAME || '  ' || AC.CUS_LNAME, 20) AS "Full Name",
    RPAD(to_char(AC.CUS_BALANCE, '$999,990.99'), 10) AS "Balance"
FROM AVIA_CUSTOMER AC
WHERE AC.CUS_CODE IN (
    SELECT CH.CUS_CODE
    FROM CHARTER CH
    WHERE CH.CHAR_DESTINATION = 'ATL');


--3.
SELECT DISTINCT
    RPAD(AE.EMP_FNAME || ' ' || AE.EMP_LNAME, 20) AS "Full Name",
    RPAD(TO_CHAR(AE.EMP_HIRE_DATE, 'FMMONTH-DD-YYYY'), 16) AS "Hire Date"
FROM AVIA_EMPLOYEE AE
WHERE AE.emp_num IN (
    SELECT ER.EMP_NUM
    FROM EARNEDRATING ER
    WHERE ER.rtg_code IN (
        SELECT ER2.rtg_code
        FROM earnedrating ER2
        WHERE ER2.emp_num = 106
    )
);

--4.
SELECT 
    RPAD(AE.emp_fname || ' ' || AE.emp_lname, 20) AS "Full Name",
    RPAD(TO_CHAR(AE.emp_dob, 'DD-MON-YYYY'), 12) AS "Birthday"
FROM avia_employee AE
MINUS
SELECT
    RPAD(AE2.emp_fname || ' ' || AE2.emp_lname, 20) AS "Full Name",
    RPAD(TO_CHAR(AE2.emp_dob, 'DD-MON-YYYY'), 12) AS "Birthday"
FROM avia_employee AE2
WHERE AE2.EMP_DOB <= (SELECT AE3.EMP_DOB
    FROM avia_employee AE3
    WHERE AE3.emp_num = 104);

--5.
SELECT
    RPAD(AC.cus_fname || ' ' || AC.cus_lname, 20) AS "Full Name",
    RPAD(AC.cus_areacode || '-' || AC.cus_phone, 20) AS "Phone Number"
FROM avia_customer AC
WHERE AC.cus_code IN (
    SELECT CH.cus_code
    FROM CHARTER CH
    GROUP BY CH.CUS_CODE
    HAVING COUNT(CH.CUS_CODE) >= (
        SELECT COUNT(*)
        FROM CHARTER CH2
        WHERE CH2.CUS_CODE = 10011
    )
);

--6.
Select 
    AC_NUMBER AS "Aircraft Number",
    MOD_CODE AS "Model Code",
    MOD_NAME AS "Name"
From MODEL 
    JOIN AIRCRAFT
    USING (MOD_CODE)
WHERE AC_NUMBER IN (
    SELECT CH.AC_NUMBER
    FROM CHARTER CH
    WHERE CH.CHAR_DATE = (
        SELECT MAX(CH2.CHAR_DATE)
        FROM CHARTER CH2)
);

--7.
SELECT 
    RPAD(AC_NUMBER, 15) AS "Aircraft Number",
    MOD_CODE AS "Model Code"
FROM AIRCRAFT
WHERE AC_NUMBER IN (
    SELECT AC_NUMBER
    FROM CHARTER
    WHERE CHAR_HOURS_FLOWN >(
    SELECT AVG(CHAR_HOURS_FLOWN)
    FROM CHARTER
    WHERE AC_NUMBER = '2778V')
);

--8.
SELECT
    RPAD(cus_fname || ' ' || cus_lname, 20) AS "Full Name",
    RPAD(cus_areacode || '-' || cus_phone, 15) AS "Phone Number"
FROM avia_customer
WHERE cus_code NOT IN (Select cus_code From charter);

--9.
SELECT
    SR.SALESREPID AS "Sales Rep ID",
    RPAD(SR.FIRSTNAME || ' ' || SR.LASTNAME, 20) AS "Full Name",
    RPAD(SR.HIGHESTDEGREE, 20) AS "Highest Degree"
FROM SALESREP SR
INTERSECT
SELECT
    SL.SALESREPID AS "Sales Rep ID",
    RPAD(SL.FIRSTNAME || ' ' || SL.LASTNAME, 20) AS "Full Name",
    RPAD(SL.HIGHESTDEGREE, 20) AS "Highest Degree"
FROM SALESREP_LEADER SL
ORDER BY "Sales Rep ID";

--10.
SELECT
    SR.SALESREPID AS "Sales Rep ID",
    RPAD(SR.FIRSTNAME || ' ' || SR.LASTNAME, 25) AS "Full Name",
    RPAD(SR.HIREDATE, 15) AS "Hire Date"
FROM SALESREP SR
UNION
SELECT
    SL.SALESREPID AS "Sales Rep ID",
    RPAD(SL.FIRSTNAME || ' ' || SL.LASTNAME, 20) AS "Full Name",
    RPAD(SL.HIREDATE, 15) AS "Hire Date"
FROM SALESREP_LEADER SL
ORDER BY "Sales Rep ID";

--11.
-- This will give the names, addresses, and home/cellphone numbers of
-- any former lead sales reps. you can send them an invitation in the mail
-- or you could call them personally to invite them.
SELECT
    RPAD(SL.FIRSTNAME || ' ' || SL.LASTNAME, 20) AS "Full Name",
    RPAD(SL.ADDRESS || SL.CITY || ', ' || SL.STATE || SL.ZIPCODE, 40) AS "Address",
    SL.HOMEPHONE AS "Home Phone",
    SL.CELLPHONE AS "Cell Phone"
FROM SALESREP_LEADER SL
MINUS
SELECT
    RPAD(SR.FIRSTNAME || ' ' || SR.LASTNAME, 20) AS "Full Name",
    RPAD(SR.ADDRESS || SR.CITY || ', ' || SR.STATE || SR.ZIPCODE, 40) AS "Address",
    SR.HOMEPHONE AS "Home Phone",
    SR.CELLPHONE AS "Cell Phone"
FROM SALESREP SR
ORDER BY "Full Name";