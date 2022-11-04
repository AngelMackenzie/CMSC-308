import java.util.*;

public class Main {
    public static void main(String[] args) throws Exception {
        Scanner scanner = new Scanner(System.in);
        Boolean flag = true;

        while (flag == true) {
            System.out.print("Number of test cases: ");
            int testCaseNum = scanner.nextInt();
            List<String> testCaseResults = new ArrayList<String>();

            // Checks if the number of test cases is valid
            if (testCaseNum > 0) {
                // Asks the user to input based on the number of test cases
                for (int i = 0; i < testCaseNum; i++) {
                    System.out.print("No. of Holidays: ");
                    int holidaysNum = scanner.nextInt();
                    scanner = new Scanner(System.in);
                    System.out.print("Day of Holidays: ");
                    String input = scanner.nextLine();

                    // Splits input string into array using white space regex
                    String[] inputs = input.split("\\s+");

                    // Check if number of inputs is equal to No. of holidays
                    if (holidaysNum == inputs.length) {
                        testCaseResults.add(processHolidays(inputs));
                    } else {
                        System.out.println();
                        System.out.println("Error invalid input");
                        testCaseResults.add("Invalid case");
                    }
                }

                System.out.println();
                for (int i = 0; i < testCaseResults.size(); i++) {
                    System.out.println(
                            String.format("Number of holidays for Test Case %s: %s ", i + 1, testCaseResults.get(i)));
                }
                flag = false;
            } else {
                System.out.println("Invalid number of test cases");
            }
        }
        scanner.close();
    }

    private static String processHolidays(String[] inputs) {
        HashSet<Integer> holidays = new HashSet<Integer>(Arrays.asList(6, 7, 13, 14, 20, 21, 27, 28));
        int[] intInputs = new int[inputs.length];
        // Try parsing input to inteegers and add it to hashset
        try {
            for (int i = 0; i < intInputs.length; i++) {
                intInputs[i] = Integer.parseInt(inputs[i]);
            }

        } catch (Exception e) {
            return "Invalid input on this test case";
        }
        // Adding inputs in holidays hashset
        for (int input : intInputs) {
            holidays.add(input);
        }

        // Sorting HashSet using List
        List<Integer> sortedHolidays = new ArrayList<Integer>(holidays);
        Collections.sort(sortedHolidays);

        String result = String.format("%s %s", sortedHolidays.size(), sortedHolidays);
        return result;
    }
}
