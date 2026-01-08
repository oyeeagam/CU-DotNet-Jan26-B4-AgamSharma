 // Exercise 1: Student Attendance & Eligibility System
        // ---------------------------------------------------
        // Attendance is stored as integers (days attended & total days)
        // Percentage is calculated as double
        // Eligibility must be shown as an integer percentage

        int daysAttended = 82;
        int totalDays = 100;

        // Convert to double before division to avoid integer division
        double attendancePercentage = (double)daysAttended / totalDays * 100;

        // Truncation (explicit cast)
        int truncatedPercentage = (int)attendancePercentage;

        // Rounding (recommended for fairness)
        int roundedPercentage = (int)Math.Round(attendancePercentage);

        Console.WriteLine("Attendance Percentage (double): " + attendancePercentage);
        Console.WriteLine("Truncated Percentage (int): " + truncatedPercentage);
        Console.WriteLine("Rounded Percentage (int): " + roundedPercentage);

        /*
        Explanation:
        - Raw data is stored as int because attendance is countable.
        - Percentage uses double to preserve decimal accuracy.
        - Casting double to int truncates (drops decimal part).
        - Math.Round gives a more accurate and fair result.
        */


        // Exercise 2: Online Examination Result Processing
        // ------------------------------------------------
        // Marks are stored as int
        // Average must be shown with two decimal places
        // Later converted to int for scholarship eligibility

        int subject1 = 85;
        int subject2 = 90;
        int subject3 = 88;

        double average = (subject1 + subject2 + subject3) / 3.0;

        // Display with two decimal places
        Console.WriteLine("Average Marks: " + average.ToString("F2"));

        // Conversion for scholarship logic
        int scholarshipAverage = (int)Math.Round(average);

        Console.WriteLine("Average Used for Scholarship (int): " + scholarshipAverage);

        /*
        Explanation:
        - int is used for marks because marks are whole numbers.
        - Division uses 3.0 to force double division.
        - Display formatting does NOT change actual value.
        - Converting double to int causes precision loss.
        - Rounding is safer than truncation for eligibility.
        */

        // Exercise 3: Library Fine Calculation System
        // -------------------------------------------
        // Fine per day is decimal
        // Days overdue is int
        // Total fine is decimal
        // Logged as double for analytics

        decimal finePerDay = 2.50m;
        int daysOverdue = 6;

        decimal totalFine = finePerDay * daysOverdue;

        // Convert decimal to double for analytics/logging
        double fineForAnalytics = (double)totalFine;

        Console.WriteLine("Total Fine (decimal): " + totalFine);
        Console.WriteLine("Fine Logged (double): " + fineForAnalytics);

        /*
        Explanation:
        - decimal is used for money to avoid precision errors.
        - int is used for countable days.
        - decimal × int stays decimal (safe).
        - double is used for analytics due to performance & storage.
        - Explicit conversion is required between decimal and double.
        */


        // Exercise 4: Banking Interest Calculation Module
        // -----------------------------------------------
        // Balance is decimal
        // Interest rate comes as float from external API
        // Monthly interest is calculated and added safely

        decimal accountBalance = 50000m;
        float interestRate = 5.5f; // from API

        // Convert float to decimal explicitly
        decimal decimalInterestRate = (decimal)interestRate;

        decimal monthlyInterest = accountBalance * decimalInterestRate / 100;
        accountBalance += monthlyInterest;

        Console.WriteLine("Monthly Interest: " + monthlyInterest);
        Console.WriteLine("Updated Balance: " + accountBalance);

        /*
        Explanation:
        - decimal is mandatory for financial accuracy.
        - float cannot be implicitly converted to decimal.
        - Explicit casting avoids compiler errors.
        - Implicit conversion may fail due to precision mismatch.
        */


        // Exercise 5: E-Commerce Order Pricing Engine
        // -------------------------------------------
        // Cart total uses double
        // Tax & discount require decimal
        // Final payable amount stored as decimal

        double cartTotal = 1999.99;

        // Convert double to decimal explicitly
        decimal cartTotalDecimal = (decimal)cartTotal;

        decimal taxRate = 18m;
        decimal discount = 200m;

        decimal taxAmount = cartTotalDecimal * taxRate / 100;
        decimal finalAmount = cartTotalDecimal + taxAmount - discount;

        Console.WriteLine("Final Payable Amount: " + finalAmount);

        /*
        Explanation:
        - double is often used during accumulation for performance.
        - decimal is used for money rules (tax, discount).
        - Explicit conversion is required to avoid precision issues.
        - Using double for final payment can cause rounding errors.
        */


        // Exercise 6: Weather Monitoring & Reporting
        // ------------------------------------------
        // Sensor sends temperature as short
        // Convert to Celsius and store as double
        // Daily average shown as int on dashboard

        short sensorReading = 302; // example raw value
        double celsiusTemperature = sensorReading / 10.0;

        int dashboardTemp = (int)Math.Round(celsiusTemperature);

        Console.WriteLine("Temperature in Celsius (double): " + celsiusTemperature);
        Console.WriteLine("Dashboard Display (int): " + dashboardTemp);

        /*
        Explanation:
        - short is used to save memory for sensor data.
        - short has limited range (-32768 to 32767).
        - Converting to double avoids overflow in calculations.
        - Casting double to int can truncate if not rounded.
        - Math.Round prevents misleading dashboard values.
        */

        // Exercise 7: University Grading Engine
        // ------------------------------------
        // Final score is double
        // Grades stored as byte (0–100)

        double finalScore = 87.6;

        // Validate before casting
        if (finalScore < 0) finalScore = 0;
        if (finalScore > 100) finalScore = 100;

        byte grade = (byte)Math.Round(finalScore);

        Console.WriteLine("Final Score (double): " + finalScore);
        Console.WriteLine("Stored Grade (byte): " + grade);

        /*
        Explanation:
        - double is used for precise score calculation.
        - byte saves memory and enforces valid grade range.
        - byte range is 0 to 255.
        - Validation prevents overflow or incorrect casting.
        - Explicit casting is mandatory from double to byte.
        */


        // Exercise 8: Mobile Data Usage Tracker
        // ------------------------------------
        // Usage stored in bytes as long
        // Displayed in MB and GB as double
        // Monthly summary rounded to int

        long dataUsedBytes = 5368709120; // 5 GB approx

        double dataInMB = dataUsedBytes / (1024.0 * 1024);
        double dataInGB = dataUsedBytes / (1024.0 * 1024 * 1024);

        int roundedGB = (int)Math.Round(dataInGB);

        Console.WriteLine("Usage in MB: " + dataInMB);
        Console.WriteLine("Usage in GB: " + dataInGB);
        Console.WriteLine("Rounded Monthly Usage (GB): " + roundedGB);

        /*
        Explanation:
        - long is used due to very large byte values.
        - Implicit conversion from long to double is allowed.
        - Division with double avoids integer truncation.
        - Math.Round ensures user-friendly summary.

        */

        // Exercise 9: Warehouse Inventory Capacity Control
        // ------------------------------------------------
        // Item count is int
        // Max capacity is ushort

        int currentItems = 450;
        ushort maxCapacity = 500;

        bool isWithinCapacity = currentItems <= maxCapacity;

        Console.WriteLine("Current Items: " + currentItems);
        Console.WriteLine("Max Capacity: " + maxCapacity);
        Console.WriteLine("Within Capacity: " + isWithinCapacity);

        /*
        Explanation:
        - int is signed and can hold negative values.
        - ushort is unsigned (0 to 65535).
        - Implicit conversion happens during comparison.
        - Risk: converting negative int to ushort causes overflow.
        - Always validate signed values before unsigned conversion.
        */

        // Exercise 10: Payroll Salary Computation
        // --------------------------------------
        // Basic salary is int
        // Allowances & deductions are double
        // Net salary stored as decimal

        int basicSalary = 40000;
        double allowances = 8500.75;
        double deductions = 3200.50;

        double grossSalary = basicSalary + allowances - deductions;

        decimal netSalary = (decimal)grossSalary;

        Console.WriteLine("Gross Salary (double): " + grossSalary);
        Console.WriteLine("Net Salary (decimal): " + netSalary);

        /*
        Explanation:
        - int is sufficient for base salary.
        - double handles fractional allowances and deductions.
        - decimal is used for final payout accuracy.
        - Explicit conversion avoids precision loss.
        - Financial data must always end in decimal.
        */