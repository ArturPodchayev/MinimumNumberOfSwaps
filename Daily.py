class Solution:
    def minSwaps(self, s: str) -> int:
        max_imbalance = 0
        balance = 0

        for char in s:
            if char == '[':
                balance += 1
            else:
                balance -= 1
                max_imbalance = max(max_imbalance, -balance)
        return (max_imbalance + 1) //2
