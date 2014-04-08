package login.com;
import android.app.Activity;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import android.test.*;
/**
 * Login
 * 
 * @author F
 * 
 */

;public class Login extends Activity implements OnClickListener{
	
	EditText use,password;
	Button login,register;
	
	Sql db;
	SQLiteDatabase sDatabase = null;
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        use = (EditText)findViewById(R.id.userName);
        password = (EditText)findViewById(R.id.password);
        login = (Button)findViewById(R.id.login);
        register = (Button)findViewById(R.id.register);
        
        register.setOnClickListener(this);
        login.setOnClickListener(this);
        
        db = new Sql(getApplicationContext(), "store.db", null, 1);
		sDatabase = db.getWritableDatabase();
		
    }

	@Override
	public void onClick(View v) {
		
		//get userName
		String i = use.getText().toString();
		
		// TODO Auto-generated method stub
		int id = v.getId();
		//reg
		if(id == R.id.register){		
			
			Intent intent = new Intent();
			intent.setClass(Login.this, Register.class);
			startActivity(intent);
		}
		//login
		if(id == R.id.login){	
			String userName = "";
			String userPw = "";
			//sqllite
			String select_sql = "select username,password from user_info where username = '"
					+ i + "'";
			//
			Cursor cursor = sDatabase.rawQuery(select_sql, null);
			cursor.moveToFirst();
			
			// get un and pw
			try
			{
				userName = cursor.getString(0);
				userPw = cursor.getString(1);
			} catch (Exception e)
			{
				// TODO: handle exception
				userName = "";
				userPw = "";
			}
//			username empty
			if (i.equals(""))
			{
				DialogDemo.builder(Login.this, "Error",
						" UserName cannot be empty!");
			}
//			password empty
			else if (password.getText().toString().equals(""))
			{
				DialogDemo.builder(Login.this, "Error",
						"password cannot be empty!");
			} 
			
//			user name and password not correct
			else if (!(use.getText().toString().equals(userName) && password
					.getText().toString().equals(userPw)))
			{
				DialogDemo.builder(Login.this, "Error",
						"UserName or password not correct");
			}
//			successful
			else
			{
				cursor.close();
				Intent intent = new Intent();
				//Bundle bundle = new Bundle();
				//bundle.putString("username",userName);
				//intent.putExtras(bundle);
				intent.setClass(Login.this, SuccessLogin.class);
				startActivity(intent);
				
				Toast.makeText(Login.this, "successful log in", Toast.LENGTH_SHORT).show();
				

			}
			
		}
		
	}



	
}