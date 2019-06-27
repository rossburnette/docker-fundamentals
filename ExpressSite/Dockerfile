FROM node:latest

MAINTAINER Jordan Jordanov

ENV NODE_ENV=production
ENV PORT=3000

COPY . /foo
WORKDIR /foo

RUN npm install

EXPOSE $PORT

ENTRYPOINT ["npm", "start"]