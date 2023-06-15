/*
*   Programmer:     Corey Jenkins
*   Date:           June 11, 2023
*   Filename:       main.tf
*   Purpose:        An introduction to using Terraform with AWS
*/

terraform{
    required_providers {
      AWS = {
        source = "hashicorp/aws"
        version = "~-> 4.16"
      }
    }

    required_version = ">= 1.2.0"
}

provider "aws" {
    region = "us-eaat-1"
  
}

resource "aws_s3_bucket" "s3_bucket"{
    bucket = "tch-app-qa-jr"
}