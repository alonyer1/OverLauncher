// AppendHosts.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <fstream>
#include <string>
#include <vector>

int main() {
    std::string path = "C:/Windows/System32/drivers/etc/hosts";
    std::string first_line = "127.0.0.1 bnet-emu.fish\n";
    std::string second_line = "127.0.0.1 us.game.bwattle.uwu\n";
    bool first_line_exists = false;
    bool second_line_exists = false;

    // Read the content of the file
    std::ifstream infile(path);
    std::vector<std::string> content;
    std::string line;

    while (std::getline(infile, line)) {
        content.push_back(line + "\n");  // Preserve the newline character
    }
    infile.close();

    // Append to the file if lines don't exist
    std::ofstream outfile(path, std::ios_base::app);

    if (std::find(content.begin(), content.end(), first_line) == content.end()) {
        outfile << "\n" << first_line;
    }
    if (std::find(content.begin(), content.end(), second_line) == content.end()) {
        outfile << second_line;
    }

    outfile.close();

    return 0;
}
// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
