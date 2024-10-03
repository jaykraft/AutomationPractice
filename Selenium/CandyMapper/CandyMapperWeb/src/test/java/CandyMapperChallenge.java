import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.annotations.Test;


public class CandyMapperChallenge extends BaseTest {
    WebDriver driver = new ChromeDriver();

    @Test
    public void CandyMapperTest() throws InterruptedException {
        driver.get("https://candymapper.com/");
        driver.manage().window().maximize();

        //Close Pop-up
        driver.findElement(By.id("popup-widget238491-close-icon")).click();

        //Fill out contact form
        driver.findElement(By.id("input19")).sendKeys("Jason");
        driver.findElement(By.id("input24")).sendKeys("testemail@test.com");
        driver.findElement(By.xpath("//*@data-aid=CONTACT_FORM_MESSAGE")).sendKeys("This is a message");

        Thread.sleep(3000);
        driver.close();
    }
}
