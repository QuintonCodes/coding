import pandas as pd

# TODO: Add validation layer (ensure required columns exist, correct types, etc.)

def clean_matches(df: pd.DataFrame) -> pd.DataFrame:
  """Clean and preprocess the matches DataFrame."""
  if df is None or df.empty:
    print("No data to clean.")
    return df

  cleaned = df[[
    'id', 'utcDate', 'status', 'matchday',
    'homeTeam.name', 'awayTeam.name',
    'score.fullTime.home', 'score.fullTime.away'
  ]].copy()

  cleaned.rename(columns={
    'homeTeam.name': 'home_team',
    'awayTeam.name': 'away_team',
    'score.fullTime.home': 'home_score',
    'score.fullTime.away': 'away_score'
  }, inplace=True)

  cleaned["utcDate"] = pd.to_datetime(cleaned["utcDate"])
  print("Matches data cleaned.")
  return cleaned