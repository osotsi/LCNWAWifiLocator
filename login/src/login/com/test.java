package login.com;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import junit.framework.TestCase;

public class test extends TestCase {
	
	void testdb(){
		SQLiteDatabase sDatabase = null;
		Sql testdb;
		testdb = new Sql(getApplicationContext(), "store.db", null, 1);
		sDatabase = testdb.getWritableDatabase();
	}

	private Context getApplicationContext() {
		return null;
	}
}
