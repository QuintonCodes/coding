import os
import pandas as pd
from utils.helpers import get_project_root

def save_raw(df: pd.DataFrame, filename: str):
    """Save raw DataFrame to a CSV file."""
    if df is None or df.empty:
        print("No data to save.")
        return

    root = get_project_root()
    raw_dir = os.path.join(root, "data", "raw")
    os.makedirs(raw_dir, exist_ok=True)

    json_path = os.path.join(raw_dir, f"{filename}.json")
    csv_path = os.path.join(raw_dir, f"{filename}.csv")

    df.to_json(json_path, orient="records", lines=True)
    print(f"Saved raw data (JSON): {json_path}")

    df.to_csv(csv_path, index=False)
    print(f"Saved raw data (CSV): {csv_path}")