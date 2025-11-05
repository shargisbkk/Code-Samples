CREATE OR REPLACE PACKAGE lab6_pkg AS

    --1a.
    PROCEDURE check_available_credit(
        p_customer_id IN DEMO_CUSTOMER.CUSTID%TYPE,
        p_purchase_amount IN NUMBER
    );

    --1b.
    PROCEDURE check_available_credit_v2(
        p_customer_id IN DEMO_CUSTOMER.CUSTID%TYPE,
        p_purchase_amount IN NUMBER
    );

    --2.
    PROCEDURE check_product_available(
        p_product_id IN MORE_PRODUCTS.PRD_ID%TYPE
    );

    --3.
    FUNCTION salary_increase(
        p_employee_id IN MORE_EMPLOYEES.EMPLOYEE_ID%TYPE,
        salary_increase IN NUMBER
    ) RETURN NUMBER;

    --4.
    PROCEDURE employee_list(
        p_division_id IN EMPLOYEES2.DIVISION_ID%TYPE
    );

    --5.
    PROCEDURE customer_charters (
        p_customer_number IN CHARTER.CUS_CODE%TYPE
    );

END lab6_pkg;
/

CREATE OR REPLACE PACKAGE BODY lab6_pkg AS

    --1a.

    PROCEDURE check_available_credit(
        p_customer_id IN DEMO_CUSTOMER.CUSTID%TYPE,
        p_purchase_amount IN NUMBER
    ) AS
        v_credit_limit DEMO_CUSTOMER.CREDITLIMIT%TYPE;
    BEGIN

        SELECT CREDITLIMIT INTO v_credit_limit
        FROM DEMO_CUSTOMER
        WHERE CUSTID = p_customer_id;
        
        IF p_purchase_amount <= v_credit_limit THEN
            DBMS_OUTPUT.PUT_LINE('Credit approved for Customer# ' || p_customer_id || '.');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Credit denied for Customer# ' || p_customer_id || '.');
        END IF;

    END check_available_credit;

    --1b.

    PROCEDURE check_available_credit_v2(
        p_customer_id IN DEMO_CUSTOMER.CUSTID%TYPE,
        p_purchase_amount IN NUMBER
    ) AS
        v_credit_limit DEMO_CUSTOMER.CREDITLIMIT%TYPE;
    BEGIN

        SELECT CREDITLIMIT INTO v_credit_limit
        FROM DEMO_CUSTOMER
        WHERE CUSTID = p_customer_id;
        
        IF p_purchase_amount <= v_credit_limit THEN
            DBMS_OUTPUT.PUT_LINE('Credit approved for Customer# ' || p_customer_id || '.');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Credit denied for Customer# ' || p_customer_id || '.');
        END IF;

    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_OUTPUT.PUT_LINE('Customer ID not found');
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('An unexpected error occurred.');
            DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);

    END check_available_credit_v2;

    --2.

    PROCEDURE check_product_available(
        p_product_id IN MORE_PRODUCTS.PRD_ID%TYPE
    )
    AS
        v_availability MORE_PRODUCTS.AVAILABLE%TYPE;
    BEGIN
        SELECT AVAILABLE INTO v_availability
        FROM MORE_PRODUCTS
        WHERE PRD_ID = p_product_id;
        
        IF v_availability = 'Y' THEN
            DBMS_OUTPUT.PUT_LINE('Product# ' || p_product_id || ' is available.');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Product# ' || p_product_id || ' is not available.');
        END IF;

    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_OUTPUT.PUT_LINE('Product ID not found');
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('An unexpected error occurred.');
            DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);
    END check_product_available;

    --3.

    FUNCTION salary_increase(
        p_employee_id IN MORE_EMPLOYEES.EMPLOYEE_ID%TYPE,
        salary_increase IN NUMBER
    ) RETURN NUMBER
    AS
        v_current_salary EMPLOYEES.SALARY%TYPE;
        new_salary NUMBER;
    BEGIN
        SELECT SALARY INTO v_current_salary
        FROM EMPLOYEES
        WHERE EMPLOYEE_ID = p_employee_id;
        
        new_salary := v_current_salary * salary_increase;
        RETURN new_salary;

    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_OUTPUT.PUT_LINE('Employee ID not found');
            RETURN NULL;
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('An unexpected error occurred.');
            DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);
            RETURN NULL;
    END salary_increase;

    --4.

    PROCEDURE employee_list(
        p_division_id IN EMPLOYEES2.DIVISION_ID%TYPE
    ) AS
        CURSOR emp_cursor IS 
            SELECT FIRST_NAME, LAST_NAME, JOB_ID, SALARY
            FROM EMPLOYEES2
            WHERE DIVISION_ID = p_division_id;
            
        v_first_name EMPLOYEES2.FIRST_NAME%TYPE;
        v_last_name EMPLOYEES2.LAST_NAME%TYPE;
        v_job_id EMPLOYEES2.JOB_ID%TYPE;
        v_salary EMPLOYEES2.SALARY%TYPE;
    BEGIN
        OPEN emp_cursor;
                    
        LOOP
            FETCH emp_cursor INTO v_first_name, v_last_name, v_job_id, v_salary;
            EXIT WHEN emp_cursor%NOTFOUND;
            
            DBMS_OUTPUT.PUT_LINE('Employee ' || v_first_name || ' ' || v_last_name ||
                ' is a ' || v_job_id || ' for division '||
                p_division_id || ' who makes $' || v_salary || ' per year.');
        END LOOP;
        
        CLOSE emp_cursor;

    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_OUTPUT.PUT_LINE('Division ID not found');
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('An unexpected error occurred.');
            DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);
    END employee_list;

    --5.

    PROCEDURE customer_charters (
        p_customer_number IN CHARTER.CUS_CODE%TYPE
    ) AS
        v_customer_code  AVIA_CUSTOMER.CUS_CODE%TYPE;
        v_Fname  AVIA_CUSTOMER.CUS_FNAME%TYPE;
        v_Lname  AVIA_CUSTOMER.CUS_LNAME%TYPE;

        Cursor c_charter IS
            SELECT CHAR_DATE, CHAR_DESTINATION, CHAR_DISTANCE, CHAR_FUEL_GALLONS
            FROM CHARTER
            WHERE CUS_CODE = p_customer_number
            ORDER BY CHAR_DATE;

        v_char_date CHARTER.CHAR_DATE%TYPE;
        v_char_destination CHARTER.CHAR_DESTINATION%TYPE;
        v_char_distance CHARTER.CHAR_DISTANCE%TYPE;
        v_char_fuel_gallons CHARTER.CHAR_FUEL_GALLONS%TYPE;

        v_total_distance NUMBER := 0;
    BEGIN
        SELECT CUS_CODE, CUS_FNAME, CUS_LNAME INTO v_customer_code, v_Fname, v_Lname
        FROM AVIA_CUSTOMER
        WHERE CUS_CODE = p_customer_number;

        DBMS_OUTPUT.PUT_LINE('Customer ' || v_customer_code || ': ' || v_Fname || ' ' || v_Lname);
        DBMS_OUTPUT.PUT_LINE('Charter History:');

        OPEN c_charter;
        LOOP
            FETCH c_charter INTO v_char_date, v_char_destination, v_char_distance, v_char_fuel_gallons;
            EXIT WHEN c_charter%NOTFOUND;

            DBMS_OUTPUT.PUT_LINE('Date: ' || TO_CHAR(v_char_date, 'MM/DD/YYYY') ||
                                ', Destination: ' || v_char_destination ||
                                ', Distance: ' || v_char_distance || ' miles' ||
                                ', Fuel Used: ' || v_char_fuel_gallons || ' gallons');

            v_total_distance := v_total_distance + v_char_distance;
        END LOOP;
        CLOSE c_charter;

        DBMS_OUTPUT.PUT_LINE('Total Distance Flown: ' || v_total_distance || ' miles');

    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_OUTPUT.PUT_LINE('Customer number not found');
        WHEN OTHERS THEN
            DBMS_OUTPUT.PUT_LINE('An unexpected error occurred.');
            DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);
    END customer_charters;

END lab6_pkg;
/

-- Test Script
BEGIN
    lab6_pkg.check_available_credit(101, 5000);
    lab6_pkg.check_available_credit(103, 5000);
    lab6_pkg.check_available_credit_v2(102, 8000);
    lab6_pkg.check_available_credit_v2(109, 5000);
    lab6_pkg.check_product_available(2);
    lab6_pkg.check_product_available(4);
    lab6_pkg.check_product_available(6);
    lab6_pkg.employee_list(BUS);
    lab6_pkg.employee_list(OPE);
    lab6_pkg.employee_list(MGR);
END;
/