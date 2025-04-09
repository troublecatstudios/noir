FROM squidfunk/mkdocs-material

RUN pip install mkdocs-macros-plugin
RUN pip install mkdocs-glightbox

WORKDIR /tmp/source

COPY mkdocs.yml     ./mkdocs.yml
COPY ./docs         /tmp/source/docs

RUN mkdocs build

EXPOSE 8000
