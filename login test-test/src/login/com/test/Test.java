package login.com.test;
import android.database.sqlite.SQLiteDatabase;
import login.com.Sql;
import junit.framework.TestCase;

public class Test extends TestCase {
	Test registerToTest;
	String userName;
	String passWord1;
	String passWord2;
	Sql db;
	SQLiteDatabase sDatabase = null;
	
	protected void setUp() throws Exception {
		registerToTest = new Test();
		userName = "TestUserName";
		passWord1 = "TestPassWord";
		passWord2 = "TestPassWord";
		super.setUp();
	}

	protected void tearDown() throws Exception {
		super.tearDown();
	}
	public void testRegister(){
		if (passWord1 == passWord2)
		{
		sDatabase.execSQL("insert into user_info values('" + 0 + "','"
				+ userName + "','" + passWord1 + "')" );
		}
		
	}

}

