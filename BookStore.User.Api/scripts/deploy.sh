#!/bin/bash
echo "Pulling Docker image from ECR..."

ACCOUNT_ID=$(aws sts get-caller-identity --query Account --output text)
REGION=$(curl -s http://169.254.169.254/latest/dynamic/instance-identity/document | jq -r .region)
REPO_URI=$ACCOUNT_ID.dkr.ecr.$REGION.amazonaws.com/user-ci-cd-demo-ecr

# Login to ECR
aws ecr get-login-password --region $REGION | docker login --username AWS --password-stdin $REPO_URI

# Stop existing container (if running)
docker stop bookstore-user-api || true
docker rm bookstore-user-api || true

# Pull latest image and run
docker pull $REPO_URI:latest
docker run -d -p 80:80 --name bookstore-user-api $REPO_URI:latest
