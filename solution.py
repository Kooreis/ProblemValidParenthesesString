def check_parentheses(s):
    stack = []
    for char in s:
        if char in ["(", "{", "["]:
            stack.append(char)
        else:
            if not stack:
                return False
            current_char = stack.pop()
            if current_char == '(':
                if char != ")":
                    return False
            if current_char == '{':
                if char != "}":
                    return False
            if current_char == '[':
                if char != "]":
                    return False
    if stack:
        return False
    return True

def main():
    s = input("Enter a string: ")
    if check_parentheses(s):
        print("The string has valid parentheses.")
    else:
        print("The string does not have valid parentheses.")

if __name__ == "__main__":
    main()