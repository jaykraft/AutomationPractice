import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeTest;

public class BaseTest {

    @BeforeTest
    public void before_test(){
        System.out.println("This runs first");
    }

    @AfterTest
    public void after_test(){
        System.out.println("This runs last");
    }
}
