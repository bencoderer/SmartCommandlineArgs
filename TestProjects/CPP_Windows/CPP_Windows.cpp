#include "pch.h"
#include <iostream>
#include <cstdlib>
#define _SILENCE_EXPERIMENTAL_FILESYSTEM_DEPRECATION_WARNING
#include <experimental/filesystem>

int main(int argc, char* argv[]) {
    // Display command line arguments
    std::cout << "Command Line Arguments:" << std::endl;
    for (int i = 0; i < argc; ++i) {
        std::cout << argv[i] << std::endl;
    }

    // Display environment variables
    const char* prefix = "SCA_";
    std::cout << "\nEnvironment Variables:" << std::endl;
    for (char** env = environ; *env; ++env) {
        int n = std::strlen(prefix);
        if (std::strncmp(*env, prefix, 4) == 0) {
            std::cout << *env << std::endl;
        }
    }

    // Display current working directory
    std::experimental::filesystem::path path = std::experimental::filesystem::current_path();
    std::cout << "Current working directory: " << path << std::endl;
    
    // wait for key press before close - not required - automatically added by visual studio
    // std::cout << "Press any key to continue..." << std::endl;
    // std::cin.get();

    return 0;
}
