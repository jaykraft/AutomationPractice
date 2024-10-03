package tests;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;

public class BaseTest {
    public static WebDriver driver;
    public static String browser = "chrome";
    public static String url = "https://parabank.parasoft.com/parabank/index.htm";


    @BeforeClass
    public static void SetUp(){
        switch (browser) {
            case "chrome" -> {
                driver = new ChromeDriver();
                driver.get(url);
                driver.manage().window().maximize();
            }
            case "edge" -> {
                driver = new EdgeDriver();
                driver.get(url);
                driver.manage().window().maximize();
            }
            case "firefox" -> {
                driver = new FirefoxDriver();
                driver.get(url);
                driver.manage().window().maximize();
            }
            default -> {
                System.out.println("Browser was not set. Default Browser is Chrome.");
                driver = new ChromeDriver();
                driver.get(url);
                driver.manage().window().maximize();
            }
        }
    }

    @AfterClass
    public static void TearDown(){
        if (driver != null) driver.close();
    }
}
