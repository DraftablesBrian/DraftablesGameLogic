
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
}

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
