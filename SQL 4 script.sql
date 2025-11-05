--1.
SELECT
    'Customer ' || AC.cus_code || 
    ' - ' || AC.cus_fname ||
    ' ' || AC.cus_lname || 
    ' owes $' || TO_CHAR(AC.cus_balance, '999,990.00') ||
    '.' AS "Customer Balance Records"
FROM avia_customer AC
WHERE AC.cus_code BETWEEN 10010 AND 10015
ORDER BY AC.cus_balance DESC;

--2.
SELECT
    S.INDUSTRY AS "Industry",
    TO_CHAR(ROUND(AVG(S.CLOSETODAY - S.CLOSEYESTERDAY), 2), 'S990.00') AS "Average Gain/Loss"
FROM STOCK S
GROUP BY S.INDUSTRY
ORDER BY S.INDUSTRY;

--3.
SELECT 
    SUM(C.CHAR_DISTANCE) AS "Total Distance",
    ROUND(SUM(C.CHAR_FUEL_GALLONS) / SUM(C.CHAR_DISTANCE), 3) AS "Avg GPM",
    COUNT(DISTINCT C.CHAR_DESTINATION) AS "Distinct Cities",
    COUNT(*) AS "# of Charters"
FROM CHARTER C;

--4a.
CREATE TABLE my_sales AS
SELECT A.YEAR, A.MONTH, A.PRD_TYPE_ID, A.EMP_ID, A.AMOUNT
FROM ALL_SALES A;

--4b.
UPDATE my_sales
SET YEAR = 2016;

--5.
SELECT 
    LPAD(TO_CHAR(ROUND(SUM(MS.AMOUNT), 0),'$999,999'), 12, '*') AS "Total Sales"
FROM MY_SALES MS
WHERE MONTH BETWEEN 1 AND 6;


--6.
SELECT 
    RPAD(AE.EMP_FNAME, 20, '.') AS Employee,
    RPAD(TO_CHAR(AE.EMP_DOB, 'FMMonth Ddsp, Year'), 50)
    AS Birthday
FROM avia_employee AE
ORDER BY AE.EMP_DOB;

--7.
SELECT
    TO_CHAR(P.CYCLEDATE, 'fmMonth') AS "Month",
    TO_CHAR(P.CYCLEDATE, 'fmDay') AS "Day of Week",
    LAST_DAY(P.CYCLEDATE) - P.CYCLEDATE AS "Days Between",
    TO_CHAR(LAST_DAY(P.CYCLEDATE), 'fmDay') AS "Last Day"
FROM PAYDAY P
ORDER BY TO_NUMBER(TO_CHAR(CYCLEDATE, 'MM'));

--8.
SELECT 
    e.first_name || ' ' || e.last_name AS "Employee",
    m.first_name || ' ' || m.last_name AS "Relative Manager"
FROM more_employees e
LEFT JOIN more_employees m
    ON e.manager_id = m.employee_id
ORDER BY "Relative Manager";

--9.
SELECT
    p.name AS "Product",
    pt.name AS "Type",
    p.price AS "Price"
FROM products p
    LEFT JOIN product_types pt
    ON p.product_type_id = pt.product_type_id
ORDER BY "Type";

--10.
SELECT 
    RPAD(TO_CHAR(TO_DATE(month, 'MM'), 'fmMonth'), 10) AS "Month",
    TO_CHAR(AVG(amount), '$999,999.00') AS "Average",
    TO_CHAR(SUM(amount), '$999,999.00') AS "Total"
FROM my_sales
GROUP BY month
HAVING AVG(amount) >= 7000
ORDER BY month;
