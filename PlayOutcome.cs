//Run vs Blitz
if (offense == OffensivePlay.Run && defense == DefensivePlay.Blitz)
{
  double avgLinebackerSpeed = AverageStat(linebackers, x => x.Speed);
  double avgLinebackerAgility = AverageStat(linebackers, x => x.Agility);
  double avgRunningBackSpeed = AverageStat(runningBacks, x => x.Speed);
  double avgRunningBackAgility = AverageStat(runningBacks, x => x.Agility);
  double avgOLinemenStrength = AverageStat(offensiveLinemen, x => x.Strength);
  double avgDLinemenStrength = AverageStat(defensiveLinemen, x => x.Strength);
  
  double linemenOutcome = avgOLinemenStrength - avgDLinemenStrength;
  double speedOutcome = avgRunningBackSpeed - avgLinebackerSpeed;
  double agilityOutcome = avgRunningBackAgility - avgLinebackerAgility;
  double gainProbability = (linemenOutcome + speedOutcome + agilityOutcome) / 10
  
    if (gainProbability >= 0.5)
  {
    gainProbability = 0.5;
  }
    if (gainProbability < 0)
    {
      gainProbability = 0;
    }
  //gainProbability should then be the percentage chance of the offensive team gaining yards. The maximum chance is 50%
}

//------------------------------------------------------------------------------------
//Pass vs Nickel
if (offense == OffensivePlay.Pass && defense == DefensivePlay.Nickel)
{
  //Speed
  double avgWideReceiverSpeed = AverageStat(wideReceiver, x => x.Speed);
  double avgCornerBackSpeed = AverageStat(cornerbacks, x => x.Agility);

  //Agility
  double avgWideReceiverAgility = AverageStat(wideReceiver, x => x.Agility);
  double avgCornerBackAgility = AverageStat(cornerbacks, x => x.Agility);
  
  //Hand-Eye
  double avgWideReceiverHandEye = AverageStat(wideReceiver, x => x.HandEye);
  double avgCornerBackHandEye = AverageStat(cornerbacks, x => x.HandEye);

  
  int speedOutcome = avgWideReceiverSpeed - avgCornerBackSpeed;
  double agilityOutcome = avgWideReceiverAgility - avgCornerBackAgility;
  double handEyeOutcome = avgWideReceiverHandEye - avgCornerBackHandEye;
  double gainProbability = (speedOutcome + agilityOutcome + handEyeOutcome) / 10
  
    if (gainProbability >= 0.5)
  {
    gainProbability = 0.5;
  }
    
}

//------------------------------------------------------------------------------------
//Option vs. Three-Four -> ADD IN QB HAND EYE?
if (offense == OffensivePlay.Option && defense == DefensivePlay.ThreeFour)
{
  //Speed
  double avgWideReceiverSpeed = AverageStat(wideReceiver, x => x.Speed);
  double avgCornerBackSpeed = AverageStat(cornerbacks, x => x.Agility);

  //Agility
  double avgWideReceiverAgility = AverageStat(wideReceiver, x => x.Agility);
  double avgCornerBackAgility = AverageStat(cornerbacks, x => x.Agility);
  
  //Hand-Eye
  double avgWideReceiverHandEye = AverageStat(wideReceiver, x => x.HandEye);
  double avgCornerBackHandEye = AverageStat(cornerbacks, x => x.HandEye);

  //Run
  //Speed
  double avgLinebackerSpeed = AverageStat(linebackers, x => x.Speed);
  double avgRunningBackSpeed = AverageStat(runningBacks, x => x.Speed);

  //agility
  double avgRunningBackAgility = AverageStat(runningBacks, x => x.Agility);
  double avgLinebackerAgility = AverageStat(linebackers, x => x.Agility);

  //strength
  double avgOLinemenStrength = AverageStat(offensiveLinemen, x => x.Strength);
  double avgDLinemenStrength = AverageStat(defensiveLinemen, x => x.Strength);

  //QB Awareness
  double avgQbAwareness = AverageStat(quarterback, x => x.Awareness);

  //Outcomes
  int passSpeedOutcome = avgWideReceiverSpeed - avgCornerBackSpeed;
  double passAgilityOutcome = avgWideReceiverAgility - avgCornerBackAgility;
  double passHandEyeOutcome = avgWideReceiverHandEye - avgCornerBackHandEye;
  double linemenOutcome = avgOLinemenStrength - avgDLinemenStrength;
  double runSpeedOutcome = avgRunningBackSpeed - avgLinebackerSpeed;
  double runAgilityOutcome = avgRunningBackAgility - avgLinebackerAgility;
  double qbAwarenessOutcome = avgQbAwareness;

  //qb awareness should negatively impact outcome if equal to or below 50
  if (avgQbAwareness <= 50)
  {
    qbAwarenessOutcome = (qbAwarenessOutcome * -0.5);
  }
  else
  {
    qbAwarenessOutcome = qbAwarenessOutcome / 2;
  }

  //final probability adjustor
  gainProbability = (passSpeedOutcome + passAgilityOutcome + passHandEyeOutcome + linemenOutcome + runSpeedOutcome + runAgilityOutcome + qbAwarenessOutcome) / 10;
  
    if (gainProbability >= 0.5)
  {
    gainProbability = 0.5;
  }
    
}

//------------------------------------------------------------------------------------
//Play action vs Four-Three -> NOT COMPLETE
if (offense == OffensivePlay.PlayAction && defense == DefensivePlay.FourThree)
{
  //Pass
  //Speed
  double avgWideReceiverSpeed = AverageStat(wideReceiver, x => x.Speed);
  double avgCornerBackSpeed = AverageStat(cornerbacks, x => x.Agility);

  //Agility
  double avgWideReceiverAgility = AverageStat(wideReceiver, x => x.Agility);
  double avgCornerBackAgility = AverageStat(cornerbacks, x => x.Agility);
  
  //Hand-Eye
  double avgWideReceiverHandEye = AverageStat(wideReceiver, x => x.HandEye);
  double avgCornerBackHandEye = AverageStat(cornerbacks, x => x.HandEye);

  //Run
  //Speed
  double avgLinebackerSpeed = AverageStat(linebackers, x => x.Speed);
  double avgRunningBackSpeed = AverageStat(runningBacks, x => x.Speed);

  //agility
  double avgRunningBackAgility = AverageStat(runningBacks, x => x.Agility);
  double avgLinebackerAgility = AverageStat(linebackers, x => x.Agility);

  //strength
  double avgOLinemenStrength = AverageStat(offensiveLinemen, x => x.Strength);
  double avgDLinemenStrength = AverageStat(defensiveLinemen, x => x.Strength);

  //QB Awareness
  double avgQbAwareness = AverageStat(quarterback, x => x.Awareness);

  //Outcomes
  int passSpeedOutcome = avgWideReceiverSpeed - avgCornerBackSpeed;
  double passAgilityOutcome = avgWideReceiverAgility - avgCornerBackAgility;
  double passHandEyeOutcome = avgWideReceiverHandEye - avgCornerBackHandEye;
  double linemenOutcome = avgOLinemenStrength - avgDLinemenStrength;
  double runSpeedOutcome = avgRunningBackSpeed - avgLinebackerSpeed;
  double runAgilityOutcome = avgRunningBackAgility - avgLinebackerAgility;
  double qbAwarenessOutcome = avgQbAwareness;

  //qb awareness should negatively impact outcome if equal to or below 50
  if (avgQbAwareness <= 50)
  {
    qbAwarenessOutcome = qbAwarenessOutcome * -1;
  }

  //final probability adjustor
  gainProbability = (passSpeedOutcome + passAgilityOutcome + passHandEyeOutcome + linemenOutcome + runSpeedOutcome + runAgilityOutcome + qbAwarenessOutcome) / 10;
  
    if (gainProbability >= 0.5)
  {
    gainProbability = 0.5;
  }
    
}

//------------------------------------------------------------------------------------
//IF GAIN == TRUE, GAIN IS BASED ON SPEED?
//IF GAIN == FALSE, LOSS IS BASED ON ????
