package kiloboltgame;

import java.awt.Graphics;

public class Robot {
	
	final int JUMPSPEED = -15;
	final int MOVESPEED = 5;
	final int GROUND = 382;

	private int centerX = 100;
	private int centerY = GROUND;
	private boolean jumped = false;
	private boolean movingLeft = false;
	private boolean movingRight = false;
	private boolean ducked = false;
	
	private static Background bg1 = StartingClass.getBg1();
	private static Background bg2 = StartingClass.getBg2();
	
	private int speedX = 0;
	private int speedY = 1;
	
	public void update()
	{
		if(speedX < 0)
		{
			centerX += speedX; //This changes centerX by adding speedX
		}
		if (speedX == 0 || speedX < 0)
		{
			bg1.setSpeedX(0);
			bg2.setSpeedX(0);
		}
		if(centerX <= 200 && speedX > 0)
		{
			centerX += speedX;
		}
		if(speedX > 0 && centerX > 200)
		{
			bg1.setSpeedX(-MOVESPEED);
			bg2.setSpeedX(-MOVESPEED);
		}
		
		/*
		else
		{
			if(centerX <= 150) //If the character's centerX is in the left 150 pixels
			{
				centerX += speedX; //Change centerX by adding speedX
			}
			else
			{
				System.out.println("Scrool Background Here");
			}
		}
		*/
		
		//Updates Y Position
		
		centerY += speedY;
		if(centerY + speedY >= GROUND) //382 is where the character's 
		{						//CenterY would be if he were standing on the ground
			centerY = GROUND;
		}

		//handles jumping
		if(jumped == true)
		{
			speedY += 1; //while character is in air, add 1 to speedY
						//THIS WILL BRING THE CHARACTER DOWNWARDS
			if(centerY + speedY >= GROUND)
			{
				centerY = GROUND;
				speedY = 0;
				jumped = false;
			}
		}
		
		//prevents going beyond X coordinate of 0
		if(centerX + speedX <= 60) //if speedX plus centerX would
		{					//bring character outside the screen
			centerX = 61;
		}	//fix the character's centerX at 60 pixels
	}
	
	public void moveRight()
	{
		if (ducked == false)
		{
			speedX = MOVESPEED;
		}
	}
	
	public void moveLeft()
	{
		if(ducked == false)
		{
			speedX = -MOVESPEED;
		}
	}
	
	public void stopRight()
	{
		setMovingRight(false);
		stop();
	}
	
	public void stopLeft()
	{
		setMovingLeft(false);
		stop();
	}
	
	private void stop()
	{
		if (isMovingRight() == false && isMovingLeft() == false)
		{
			speedX = 0;
		}
		
		if(isMovingRight() == false && isMovingLeft() == true)
		{
			moveLeft();
		}
		
		if (isMovingRight() == true && isMovingLeft() == false)
		{
			moveRight();
		}
	}
	
	public void jump()
	{
		if(jumped == false)
		{
			speedY = JUMPSPEED;
			jumped = true;
		}
	}
	
	public int getCenterX() {
		if(ducked == false)
		{
			speedX = -MOVESPEED;
		}
		return centerX;
	}

	public void setCenterX(int centerX) {
		this.centerX = centerX;
	}

	public int getCenterY() {
		return centerY;
	}

	public void setCenterY(int centerY) {
		this.centerY = centerY;
	}

	public boolean isJumped() {
		return jumped;
	}

	public void setJumped(boolean jumped) {
		this.jumped = jumped;
	}

	public int getSpeedX() {
		return speedX;
	}

	public void setSpeedX(int speedX) {
		this.speedX = speedX;
	}

	public int getSpeedY() {
		return speedY;
	}

	public void setSpeedY(int speedY) {
		this.speedY = speedY;
	}
	
	public boolean isDucked()
	{
		return ducked;
	}
	
	public void setDucked(boolean ducked)
	{
		this.ducked = ducked;
	}
	
	public boolean isMovingRight()
	{
		return movingRight;
	}
	
	public void setMovingRight(boolean movingRight)
	{
		this.movingRight = movingRight;
	}
	
	public boolean isMovingLeft()
	{
		return movingLeft;
	}
	
	public void setMovingLeft(boolean movingLeft)
	{
		this.movingLeft = movingLeft;
	}


}
