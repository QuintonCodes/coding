import os
import pandas as pd
from utils.helpers import get_project_root

def save_processed(df: pd.DataFrame, filename: str):
    """Save processed DataFrame to a CSV file."""
    if df is None or df.empty:
        print("No processed data to save.")
        return

    root = get_project_root()
    processed_dir = os.path.join(root, "data", "processed")
    os.makedirs(processed_dir, exist_ok=True)

    csv_path = os.path.join(processed_dir, f"{filename}.csv")
    df.to_csv(csv_path, index=False)
    print(f"Saved processed data: {csv_path}")