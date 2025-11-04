package countrylistmanager;

import java.util.ArrayList;
import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class CountryIO {
    public ArrayList<String> getCountries(){
        ArrayList<String> countries = new ArrayList<>();
        
        try{
            // instantiate the file reader, reading the 'countries' txt file in the same directory
            BufferedReader reader = new BufferedReader(new FileReader("countries.txt"));
            // 'line' will hold each line of text read from the txt file
            String line;
            // read each line in the file, store it in 'line', when a null value is stored in line the loop will break
            while((line = reader.readLine()) != null){
                // add the line of text to the ArrayList 'countries'
                countries.add(line);
            }
            // close the reader to prevent memory leaks
            reader.close();
        }
        // catch any IO exceptions thrown
        catch(IOException e){
            System.out.print("Cannot locate file to read. ");
        }
        // output the ArrayList of countries
        return countries;
    }
    
    public boolean saveCountries(ArrayList<String>countries){
        try{
            // instantiate the filewriter, creating the txt file in the same directory
            BufferedWriter writer = new BufferedWriter(new FileWriter("countries.txt"));
            // write each country's name on its own line in the txt file
            for (String country : countries){
                writer.write(country + "\n");
            }
            // close the writer to prevent memory leaks
            writer.close();
            return true;
        }
        // catch any IO exceptions thrown
        catch(IOException e) {
            return false;
        }
        
    }
}
